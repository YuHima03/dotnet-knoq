using Microsoft.Extensions.Configuration;

namespace Knoq.Tests.Helpers
{
    public class KnoqApiClientFixture : IDisposable
    {
        public Task<KnoqApiClient> ClientTask { get; }

        readonly CancellationTokenSource _cts = new();

        public KnoqApiClientFixture()
        {
            using var envFileStream = File.OpenRead(Path.Combine(Environment.CurrentDirectory ?? "", ".env"));
            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddIniStream(envFileStream)
                .Build();
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
