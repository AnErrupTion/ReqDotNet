using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;

namespace ReqDotNet
{
    public class Requests
    {
        public HttpMethod Method;
        public Encoding ContentEncoding;

        public string Address;
        public string UserAgent;
        public string PostData;
        public string ContentType;
        public string Cookies;
        public string Proxy;

        public bool UseCookies;
        public bool UseProxies;

        public int Timeout;

        public async Task<HttpResponseMessage> SendRequest()
        {
            HttpClientHandler handler = new HttpClientHandler { UseCookies = false, UseProxy = UseProxies };
            if (handler.UseProxy)
            {
                handler.Proxy = ProxyHandler.ToWebProxy(Proxy);
                handler.PreAuthenticate = true;
                handler.UseDefaultCredentials = true;
            }

            HttpClient client = new HttpClient(handler)
            {
                BaseAddress = new Uri(Address),
                Timeout = TimeSpan.FromMilliseconds(Timeout)
            };

            client.DefaultRequestHeaders.UserAgent.ParseAdd(UserAgent);

            HttpRequestMessage req = new HttpRequestMessage(Method, client.BaseAddress);
            if (Method.Equals(HttpMethod.Post)) req.Content = new StringContent(PostData, ContentEncoding, ContentType);
            if (UseCookies) req.Headers.Add("Cookie", Cookies);

            return await client.SendAsync(req);
        }

        public async Task<string> SendRequestToString() { return await SendRequest().Result.Content.ReadAsStringAsync(); }
    }
}
