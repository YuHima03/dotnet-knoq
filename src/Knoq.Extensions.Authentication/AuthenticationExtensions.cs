namespace Knoq.Extensions.Authentication
{
    public static class AuthenticationExtensions
    {
        public static async ValueTask<string> GetKnoqAccessTokenAsync(string knoqBaseAddress, string traqBaseAddress, TraqAuthenticationInfo traqAuthInfo, CancellationToken ct)
        {
            HttpClientHandler clientHandler = new()
            {
                UseCookies = true,
                AllowAutoRedirect = false
            };
            using HttpClient client = new(clientHandler, true);

            Traq.Client.Configuration traqApiConfig = new() { BasePath = traqBaseAddress };
            Knoq.Client.Configuration knoqApiConfig = new() { BasePath = knoqBaseAddress };

            // First, login to traQ.
            if (traqAuthInfo.CookieAuthToken is not null)
            {
                Uri traqBaseUri = new(traqBaseAddress);
                // Use cookie authentication.
                // Client must have a token in the cookie to pass the OAuth2 authorization flow of knoQ.
                clientHandler.CookieContainer.Add(new System.Net.Cookie
                {
                    Domain = traqBaseUri.Host,
                    HttpOnly = true,
                    Name = "r_session",
                    Path = "/",
                    Secure = traqBaseUri.Scheme == Uri.UriSchemeHttps,
                    Value = traqAuthInfo.CookieAuthToken,
                });
            }
            else if (traqAuthInfo.Username is not null && traqAuthInfo.Password is not null)
            {
                // Use password authentication.
                Traq.Api.AuthenticationApi authApi = new(client, traqApiConfig, clientHandler);
                Traq.Model.PostLoginRequest req = new(
                    name: traqAuthInfo.Username ?? string.Empty,
                    password: traqAuthInfo.Password ?? string.Empty
                );
                await authApi.LoginAsync(null, req, ct).ConfigureAwait(false);
            }
            else
            {
                throw new ArgumentException("Either CookieAuthToken or Username+Password must be provided.");
            }

            // Then, get the uri of traQ's OAuth2 authorization endpoint.
            // The uri should be like "https://q.trap.jp/oauth2/authorize"
            Uri oAuth2Uri;
            {
                Api.AuthenticationApi authApi = new(client, knoqApiConfig, clientHandler);
                var authParams = await authApi.GetAuthParamsAsync(ct).ConfigureAwait(false);
                oAuth2Uri = new(authParams.Url);
            }

            // Next, access the traQ's OAuth2 authorization endpoint.
            // It should be redirected to the consent page.
            {
                var res = await client.GetAsync(oAuth2Uri, ct).ConfigureAwait(false); // Should be redirected to https://q.trap.jp/consent
                if (res.StatusCode == System.Net.HttpStatusCode.Found)
                {
                    if (res.Headers.Location is Uri location)
                    {
                        var redirectRes = await client.GetAsync(location.IsAbsoluteUri ? location : new Uri(new Uri($"{oAuth2Uri.Scheme}://{oAuth2Uri.Host}"), location.ToString()), ct).ConfigureAwait(false);
                        if (!redirectRes.IsSuccessStatusCode)
                        {
                            throw new Exception("Failed to access redirect url.");
                        }
                    }
                }
            }

            // Finally, approve the consent.
            // It should be redirected to the callback url of the knoQ service.
            {
                Traq.Api.Oauth2Api oauth2Api = new(client, traqApiConfig, clientHandler);
                var res = await oauth2Api.PostOAuth2AuthorizeDecideWithHttpInfoAsync("approve", ct).ConfigureAwait(false);
                if (res.StatusCode == System.Net.HttpStatusCode.Found)
                {
                    if (Uri.TryCreate(res.Headers["Location"].FirstOrDefault(), UriKind.RelativeOrAbsolute, out var location))
                    {
                        var redirectRes = await client.GetAsync(location, ct).ConfigureAwait(false); // Should be redirected to https://knoq.trap.jp/api/callback
                        if (redirectRes.StatusCode != System.Net.HttpStatusCode.Found && !redirectRes.IsSuccessStatusCode)
                        {
                            throw new Exception("Http request failed.");
                        }
                    }
                }
            }

            UriBuilder cookieUri = new(knoqApiConfig.BasePath)
            {
                Fragment = "",
                Path = "",
                Query = ""
            };
            return clientHandler.CookieContainer.GetCookies(cookieUri.Uri).Where(c => c.Name == "session").First().Value; // Extract the session cookie to access to the knoQ API.
        }
    }
}
