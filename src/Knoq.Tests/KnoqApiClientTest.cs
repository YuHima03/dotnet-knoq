using Knoq.Tests.Helpers;

namespace Knoq.Tests
{
    public class KnoqApiClientTest(KnoqApiClientFixture clientProvider) : IClassFixture<KnoqApiClientFixture>
    {
        [Fact]
        public async Task GetEventsAsyncTest()
        {
            var knoq = await clientProvider.ClientTask;
            var events = await knoq.Events.GetAsync();
            Assert.NotNull(events);
        }
    }
}
