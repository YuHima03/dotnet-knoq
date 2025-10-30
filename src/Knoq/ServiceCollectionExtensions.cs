using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using System;

namespace Knoq
{
    /// <summary>
    /// Provides extension methods for the <see cref="IServiceCollection"/> interface.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton instance of the <see cref="KnoqApiClient"/> class to the service collection.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add.</param>
        public static IServiceCollection AddKnoqApiClient(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(services);
            services.TryAddSingleton(sp => KnoqApiClientHelper.CreateFromOptions(sp.GetRequiredService<IOptions<KnoqApiClientOptions>>().Value));
            return services;
        }

        /// <summary>
        /// Adds a singleton service for the <see cref="KnoqApiClient"/> interface and a configuration for the instance to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <param name="configureOptions">The configurator for instances of the <see cref="KnoqApiClient"/> interface.</param>
        /// <returns></returns>
        public static IServiceCollection AddKnoqApiClient(this IServiceCollection services, Action<KnoqApiClientOptions> configureOptions)
        {
            ArgumentNullException.ThrowIfNull(services);
            ArgumentNullException.ThrowIfNull(configureOptions);
            return services
                .Configure(configureOptions)
                .AddKnoqApiClient();
        }

        /// <summary>
        /// Add a singleton instance of the <see cref="KnoqApiClient"/> class configured by the <paramref name="configureOptions"/> to the service collection.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add.</param>
        /// <param name="configureOptions">The action to configure the options.</param>
        public static IServiceCollection AddKnoqApiClient(this IServiceCollection services, Action<IServiceProvider, KnoqApiClientOptions> configureOptions)
        {
            ArgumentNullException.ThrowIfNull(services);
            ArgumentNullException.ThrowIfNull(configureOptions);
            return services
                .AddSingleton<IConfigureOptions<KnoqApiClientOptions>>(sp => new ConfigureOptions<KnoqApiClientOptions>(options => configureOptions(sp, options)))
                .AddKnoqApiClient();
        }
    }
}
