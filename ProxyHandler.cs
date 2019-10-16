using System.Net;

namespace ReqDotNet
{
    public class ProxyHandler
    {
        public static IWebProxy ToWebProxy(string proxy) { return new WebProxy("http://" + proxy, false); }
    }
}
