using NUnit.Framework;

namespace HealthCheck.Samples.Test
{
    [TestFixture]
    public class AlwaysTrueHealthCheckTests
    {
        [Test]
        public void Check_WhenCalled_ReturnsTrue()
        {
            var result = new AlwaysTrueHealthCheck("Always True").Execute();
            Assert.IsTrue(result.IsHealthy);
        }
    }
}
