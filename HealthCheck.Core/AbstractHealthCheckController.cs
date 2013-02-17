using System.Web.Mvc;

namespace HealthCheck.Core
{
    public abstract class AbstractHealthCheckController : Controller
    {
        private readonly HealthCheckRegistry _healthCheckRegistry = new HealthCheckRegistry();

        protected HealthCheckRegistry HealthCheckRegistry { get { return _healthCheckRegistry; } }

        public ActionResult Index()
        {
            if (HealthCheckRegistry.Count() == 0)
                return Json("No health checks are registered.");

            return Json(_healthCheckRegistry.RunHealthChecks(), JsonRequestBehavior.AllowGet);
        }
    }
}
