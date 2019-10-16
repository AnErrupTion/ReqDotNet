using System.Net.Http;
using System.Threading.Tasks;

namespace ReqDotNet
{
    public static class WebsiteUtils
    {

        public async static Task<string> GetPageSource(string address)
        {
            Requests r = new Requests()
            {
                Method = HttpMethod.Get,
                Address = address,
                UserAgent = UserAgent.Chrome(),
                Timeout = 5000
            };

            return await r.SendRequestToString();
        }

        public async static Task<bool> TestWebsite(string address, int timeout = 10000)
        {
            Requests r = new Requests()
            {
                Method = HttpMethod.Get,
                Address = address,
                UserAgent = UserAgent.Chrome(),
                Timeout = timeout
            };

            var response = await r.SendRequest();
            return response.IsSuccessStatusCode;
        }
    }
}
