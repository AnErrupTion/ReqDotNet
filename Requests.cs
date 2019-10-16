using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;

namespace ReqDotNet
{
    public class Requests
    {
        public HttpMethod Method;
        public string Address;
        public string UserAgent;
        public string PostData;
        public string ContentType;
        public Encoding ContentEncoding;
        public bool UseCookies;
        public string Cookies;
        public bool UseProxies;
        public string Proxy;
        public int Timeout;

        public async Task<HttpResponseMessage> SendRequest()
        {
            HttpClientHandler handler = new HttpClientHandler { UseCookies = false, UseProxy = UseProxies };
            if (UseProxies) handler.Proxy = ProxyHandler.ToWebProxy(Proxy);

            HttpClient client = new HttpClient(handler);
            client.BaseAddress = new Uri(Address);
            client.DefaultRequestHeaders.UserAgent.ParseAdd(UserAgent);
            client.Timeout = TimeSpan.FromMilliseconds(Timeout);

            HttpRequestMessage req = new HttpRequestMessage(Method, client.BaseAddress);
            if (Method == HttpMethod.Post) req.Content = new StringContent(PostData, ContentEncoding, ContentType);
            if (UseCookies) req.Headers.Add("Cookie", Cookies);

            return await client.SendAsync(req);
        }

        public async Task<string> SendRequestToString() { return await SendRequest().Result.Content.ReadAsStringAsync(); }
    }
}
