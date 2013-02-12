using NUnit.Framework;

namespace HealthCheck.Samples.Test
{
    [TestFixture]
    class CanReachUriHealthCheckTests
    {
        [Test]
        public void Check_WithReachableUri_ReturnsHealthy()
        {
            var result = new CanReachUriHealthCheck("Google", "http://google.com/").Execute();
            Assert.IsTrue(result.IsHealthy);
        }

        [Test]
        public void Check_WithUnreachableUri_ReturnsNotHealthy()
        {
            var result = new CanReachUriHealthCheck("A URI That Does Not Work", "http://a-uri-that-does-not-work.com/").Execute();
            Assert.IsFalse(result.IsHealthy);
        }
    }
}
