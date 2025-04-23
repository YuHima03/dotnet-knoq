using Microsoft.Extensions.DependencyInjection;
using System;

namespace Knoq
{
    /// <summary>
    /// Provides extension methods for the <see cref="IServiceCollection"/> interface.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton service for the <see cref="IKnoqApiClient"/> interface and a configuration for the instance to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <param name="configure">The configurator for instances of the <see cref="IKnoqApiClient"/> interface.</param>
        /// <returns></returns>
        public static IServiceCollection AddKnoqApiClient(this IServiceCollection services, Action<KnoqApiClientOptions> configure)
        {
            return services
                .Configure(configure)
                .AddSingleton<IKnoqApiClient, KnoqApiClient>();
        }
    }
}
