using HealthCheck.Core;

namespace HealthCheck.Sample.Mvc.Controllers
{
    public class HealthCheckController : AbstractHealthCheckController
    {
        public HealthCheckController()
        {
            HealthCheckRegistry.Register(new AlwaysTrueHealthCheck("Sample 1"));
            HealthCheckRegistry.Register(new AlwaysTrueHealthCheck("Sample 2"));
            HealthCheckRegistry.Register(new AlwaysTrueHealthCheck("Sample 3"));
            HealthCheckRegistry.Register(new CanReachUriHealthCheck("Google", "http://google.com/"));
            HealthCheckRegistry.Register(new CanReachUriHealthCheck("A bad uri", "http://a-uri-that-does-not-work.com"));
        }
    }
}
