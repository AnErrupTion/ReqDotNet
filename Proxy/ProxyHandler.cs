using System.Net;
using System;

namespace ReqDotNet
{
    public class ProxyHandler
    {
        public static IWebProxy ToWebProxy(string proxy)
        {
            var p = new WebProxy
            {
                Address = new Uri(proxy),
                BypassProxyOnLocal = false,
                UseDefaultCredentials = true
            };

            return p;
        }
    }
}
