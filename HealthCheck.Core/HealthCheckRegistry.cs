using System.Collections.Generic;
using System.Linq;

namespace HealthCheck.Core
{
    public class HealthCheckRegistry
    {
        private readonly Dictionary<string, AbstractHealthCheck> _healthChecks = new Dictionary<string, AbstractHealthCheck>();

        public void Register(AbstractHealthCheck healthCheck)
        {
            _healthChecks.Add(healthCheck.Name, healthCheck);
        }

        public void Unregister(string name)
        {
            _healthChecks.Remove(name);
        }

        public void Unregister(AbstractHealthCheck healthCheck)
        {
            Unregister(healthCheck.Name);
        }

        public IEnumerable<Result> RunHealthChecks()
        {
            return _healthChecks.Values.Select(healthCheck => healthCheck.Execute()).ToList();
        }
    }
}
