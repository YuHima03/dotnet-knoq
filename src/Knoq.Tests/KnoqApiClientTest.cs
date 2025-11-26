using Knoq.Tests.Helpers;

namespace Knoq.Tests
{
    public class KnoqApiClientTest(KnoqApiClientFixture clientProvider) : IClassFixture<KnoqApiClientFixture>
    {
        [Fact(SkipExceptions = [typeof(KnoqApiClientProvider.KnoqApiClientCreationFailedException)])]
        public async Task GetEventsAsyncTest()
        {
            var knoq = await clientProvider.ClientTask;
            var events = await knoq.Events.GetAsync(cancellationToken: TestContext.Current.CancellationToken);
            Assert.NotNull(events);
        }
    }
}
