using System;

namespace HealthCheck.Core
{
    public abstract class AbstractHealthCheck
    {
        protected AbstractHealthCheck(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        protected abstract Result Check();

        public Result Execute()
        {
            try
            {
                return Check();
            }
            catch (Exception e)
            {
                return new Result(false, e.Message, e);
            }
        }
    }
}
