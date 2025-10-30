using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Traq;

namespace Knoq.Extensions.Authentication
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAuthenticatedKnoqApiClient(this IServiceCollection services, Action<IServiceProvider, KnoqApiClientOptions> configureKnoq, Action<IServiceProvider, TraqAuthenticationInfo> configureTraqAuth)
        {
            return services
                .AddOptions()
                .AddKnoqApiClient((sp, options) => {
                    // options
                    var traqOptions = sp.GetRequiredService<IOptions<TraqApiClientOptions>>().Value;
                    TraqAuthenticationInfo traqAuthInfo = new();

                    // configure
                    configureKnoq.Invoke(sp, options);
                    configureTraqAuth.Invoke(sp, traqAuthInfo);

                    var task = AuthenticationExtensions.GetKnoqAccessTokenAsync(options.BaseAddress, traqOptions.BaseAddress, traqAuthInfo, CancellationToken.None).AsTask();
                    task.Wait();
                    options.CookieAuthToken = task.Result;
                });
        }
    }
}
