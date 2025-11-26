using Microsoft.Extensions.Configuration;

namespace Knoq.Tests.Helpers
{
    public class KnoqApiClientFixture : IDisposable
    {
        public Task<KnoqApiClient> ClientTask { get; }

        readonly CancellationTokenSource _cts = new();

        public KnoqApiClientFixture()
        {
            var configBuilder = new ConfigurationBuilder()
                .AddEnvironmentVariables();

            var envFilePath = Path.Combine(Environment.CurrentDirectory ?? "", ".env");
            using var envFileStream = File.Exists(envFilePath) ? File.OpenRead(envFilePath) : null;
            if (envFileStream is not null)
            {
                configBuilder.AddIniStream(envFileStream);
            }

            var config = configBuilder.Build();
            ClientTask = KnoqApiClientProvider.GetKnoqApiClientAsync(config, _cts.Token);
        }

        public void Dispose()
        {
            _cts.Cancel();
            _cts.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
