using System;

namespace HealthCheck.Core
{
    public class Result
    {
        public Result(bool isHealthy, string name, string message, Exception exception)
        {
            IsHealthy = isHealthy;
            Name = name;
            Message = message;
            Exception = exception;
        }

        public bool IsHealthy { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}
