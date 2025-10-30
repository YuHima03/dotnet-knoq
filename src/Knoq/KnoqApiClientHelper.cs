using CommunityToolkit.Diagnostics;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System;
using System.Net.Http;

namespace Knoq
{
    /// <summary>
    /// Provides helper methods for creating instances of <see cref="KnoqApiClient"/> configured with <see cref="KnoqApiClientOptions"/>.
    /// </summary>
    public static class KnoqApiClientHelper
    {
        const string CookieAuthenticationCookieName = "session";

        /// <summary>
        /// Creates a new instance of <see cref="KnoqApiClient"/> using the specified options.
        /// </summary>
        /// <param name="options">
        /// Options for configuring the <see cref="KnoqApiClient"/>.
        /// </param>
        /// <returns>A configured <see cref="KnoqApiClient"/> instance ready for use.</returns>
        public static KnoqApiClient CreateFromOptions(IReadOnlyKnoqApiClientOptions options)
        {
            ArgumentNullException.ThrowIfNull(options);
            ArgumentException.ThrowIfNullOrWhiteSpace(options.BaseAddress);

            if (string.IsNullOrWhiteSpace(options.CookieAuthToken))
            {
                ThrowHelper.ThrowInvalidOperationException("Cookie authentication token is not set.");
            }

            Uri baseAddress = new(options.BaseAddress, UriKind.Absolute);
            HttpClientHandler clientHandler = new()
            {
                AllowAutoRedirect = false,
                UseCookies = true
            };
            clientHandler.CookieContainer.Add(new System.Net.Cookie
            {
                Domain = baseAddress.Host,
                HttpOnly = true,
                Name = CookieAuthenticationCookieName,
                Path = "/",
                Secure = baseAddress.Scheme == Uri.UriSchemeHttps,
                Value = options.CookieAuthToken,
            });
            HttpClient client = new(clientHandler);

            return new(new HttpClientRequestAdapter(new AnonymousAuthenticationProvider(), httpClient: client) { BaseUrl = options.BaseAddress });
        }
    }
}
