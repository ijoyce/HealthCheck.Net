using System;
using System.Net;
using System.Net.Http;
using HealthCheck.Core;

namespace HealthCheck.Samples
{
    public class CanReachUriHealthCheck : AbstractHealthCheck
    {
        private readonly string _uri;

        public CanReachUriHealthCheck(string name) : base(name)
        {
        }

        public CanReachUriHealthCheck(string name, string uri) : this(name)
        {
            if (string.IsNullOrWhiteSpace(uri))
                throw new ArgumentNullException("uri");

            _uri = uri;
        }

        public override Result Check()
        {
            var client = new HttpClient();
            var response = client.GetAsync(_uri).Result;
            return new Result(response.StatusCode == HttpStatusCode.OK, response.StatusCode.ToString(), null);
        }
    }
}
