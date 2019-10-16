using System.Collections.Generic;

namespace ReqDotNet
{
    public class CookieStorage
    {
        private static Dictionary<string, string> tempCookies = new Dictionary<string, string>();

        public static void Add(string name, string value)
        {
            tempCookies.Add(name, value);
        }

        public static string Get(string name)
        {
            string cookie = string.Empty;
            foreach (var c in tempCookies) if (c.Key.Contains(name)) cookie = string.Format("{0}={1}; ", c.Key, c.Value);
            return cookie;
        }
    }
}
