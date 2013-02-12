using HealthCheck.Core;

namespace HealthCheck.Samples
{
    public class AlwaysTrueHealthCheck : AbstractHealthCheck
    {
        public AlwaysTrueHealthCheck(string name) : base(name)
        {
        }

        protected override Result Check()
        {
            return new Result(true, null, null);
        }
    }
}
