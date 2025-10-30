using CommunityToolkit.Diagnostics;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System.Diagnostics.CodeAnalysis;
using Traq;

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

            AnonymousAuthenticationProvider authProvider = new();
            TraqApiClient traqApiClient = new(new HttpClientRequestAdapter(authProvider, httpClient: client) { BaseUrl = traqBaseAddress });
            KnoqApiClient knoqApiClient = new(new HttpClientRequestAdapter(authProvider, httpClient: client) { BaseUrl = knoqBaseAddress });

            // First, login to traQ.
            if (traqAuthInfo.CookieAuthToken is not null)
            {
                Uri traqBaseUri = new(traqBaseAddress, UriKind.Absolute);
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
            else if (!string.IsNullOrWhiteSpace(traqAuthInfo.Username) && traqAuthInfo.Password is not null)
            {
                // Use password authentication.
                await traqApiClient.Login.PostAsync(new() { Name = traqAuthInfo.Username, Password = traqAuthInfo.Password }, cancellationToken: ct);
            }
            else
            {
                ThrowHelper.ThrowArgumentException("Either CookieAuthToken or Username+Password must be provided.");
            }

            // Then, get the uri of traQ's OAuth2 authorization endpoint.
            // The uri should be like "https://q.trap.jp/oauth2/authorize"
            var knoqAuthParams = await knoqApiClient.AuthParams.PostAsync(cancellationToken: ct);
            Guard.IsNotNull(knoqAuthParams);
            Guard.IsNotNullOrWhiteSpace(knoqAuthParams.Url);
            Uri oAuth2Uri = new(knoqAuthParams.Url, UriKind.Absolute);

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
                            ThrowHelperInternal.Throw("Failed to access redirect url.");
                        }
                    }
                }
            }

            // Finally, approve the consent.
            // It should be redirected to the callback url of the knoQ service.
            {
                var reqInfo = traqApiClient.Oauth2.Authorize.Decide.ToPostRequestInformation(new() { Submit = "approve" });
                using StreamContent reqContent = new(reqInfo.Content);
                using var res = await client.PostAsync(reqInfo.URI, reqContent, ct);
                if (res.StatusCode == System.Net.HttpStatusCode.Found)
                {
                    if (Uri.TryCreate(res.Headers.GetValues("Location").FirstOrDefault(), UriKind.RelativeOrAbsolute, out var location))
                    {
                        using var redirectRes = await client.GetAsync(location, ct).ConfigureAwait(false); // Should be redirected to https://knoq.trap.jp/api/callback
                        if (redirectRes.StatusCode != System.Net.HttpStatusCode.Found && !redirectRes.IsSuccessStatusCode)
                        {
                            ThrowHelperInternal.Throw("Http request failed.");
                        }
                    }
                }
            }

            UriBuilder cookieUri = new(knoqBaseAddress)
            {
                Fragment = "",
                Path = "",
                Query = ""
            };
            return clientHandler.CookieContainer.GetCookies(cookieUri.Uri).Where(c => c.Name == "session").First().Value; // Extract the session cookie to access to the knoQ API.
        }
    }

    file static class ThrowHelperInternal
    {
        [DoesNotReturn]
        public static void Throw(string message)
        {
            throw new Exception(message);
        }
    }
}
