using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Traq;

namespace Knoq.Extensions.Authentication
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAuthenticatedKnoqApiClient(this IServiceCollection services, Action<KnoqApiClientOptions> configureKnoq, TraqAuthenticationInfo traqAuthInfo)
        {
            return services
                .AddOptions()
                .AddSingleton<IConfigureOptions<KnoqApiClientOptions>>(sp => {
                    return new ConfigureNamedOptions<KnoqApiClientOptions>(Options.DefaultName, options => {
                        configureKnoq.Invoke(options);
                        var traqOptions = sp.GetRequiredService<IOptions<TraqApiClientOptions>>().Value;
                        var task = AuthenticationExtensions.GetKnoqAccessTokenAsync(options.BaseAddress, traqOptions.BaseAddress, traqAuthInfo, CancellationToken.None).AsTask();
                        task.Wait();
                        options.CookieAuthToken = task.Result;
                    });
                })
                .AddSingleton<IKnoqApiClient, KnoqApiClient>();
        }
    }
}
