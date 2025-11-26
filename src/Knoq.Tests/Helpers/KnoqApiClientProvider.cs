using Knoq.Extensions.Authentication;
using Microsoft.Extensions.Configuration;

namespace Knoq.Tests.Helpers
{
    static class KnoqApiClientProvider
    {
        public static async Task<KnoqApiClient> GetKnoqApiClientAsync(IConfiguration config, CancellationToken ct = default)
        {
            try
            {
                var knoqConfig = config.Get<KnoqApiClientConfiguration>()!;
                var traqConfig = config.Get<TraqApiClientConfiguration>()!;
                if (!string.IsNullOrWhiteSpace(knoqConfig.CookieAuthToken))
                {
                    return KnoqApiClientHelper.CreateFromOptions(new KnoqApiClientOptions { BaseAddress = knoqConfig.BaseAddress, CookieAuthToken = knoqConfig.CookieAuthToken });
                }
                TraqAuthenticationInfo traqAuthInfo = new();
                if (traqConfig.CookieAuthToken is not null)
                {
                    traqAuthInfo.UseCookieAuthentication(traqConfig.CookieAuthToken);
                }
                if (!string.IsNullOrWhiteSpace(traqConfig.Username) && !string.IsNullOrWhiteSpace(traqConfig.Password))
                {
                    traqAuthInfo.UsePasswordAuthentication(traqConfig.Username, traqConfig.Password);
                }
                var knoqCookieToken = await AuthenticationExtensions.GetKnoqAccessTokenAsync(
                    knoqConfig.BaseAddress,
                    traqConfig.BaseAddress,
                    traqAuthInfo,
                    ct
                ).ConfigureAwait(false);
                return KnoqApiClientHelper.CreateFromOptions(new KnoqApiClientOptions { BaseAddress = knoqConfig.BaseAddress, CookieAuthToken = knoqCookieToken });
            }
            catch (Exception ex)
            {
                throw new KnoqApiClientCreationFailedException("Failed to create a KnoqApiClient from the configuration.", ex);
            }
        }

        public sealed class KnoqApiClientCreationFailedException(string message, Exception? innerException) : Exception(message, innerException);
    }

    file class KnoqApiClientConfiguration
    {
        [ConfigurationKeyName("KNOQ_API_BASE_ADDRESS")]
        public string BaseAddress { get; set; } = "";

        [ConfigurationKeyName("KNOQ_COOKIE_TOKEN")]
        public string CookieAuthToken { get; set; } = "";
    }

    file class TraqApiClientConfiguration
    {
        [ConfigurationKeyName("TRAQ_API_BASE_ADDRESS")]
        public string BaseAddress { get; set; } = "";

        [ConfigurationKeyName("TRAQ_COOKIE_TOKEN")]
        public string? CookieAuthToken { get; set; }

        [ConfigurationKeyName("TRAQ_USERNAME")]
        public string? Username { get; set; }

        [ConfigurationKeyName("TRAQ_PASSWORD")]
        public string? Password { get; set; }
    }
}
