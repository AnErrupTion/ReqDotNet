using System;

namespace ReqDotNet
{
    public class UserAgent
    {
        private static string[] UserAgents = { "Mozilla/5.0 ({0}; WOW64; Trident/{1}; rv:{2}) like Gecko", "Mozilla/5.0 ({0}; {1}) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/{2} Safari/537.36 OPR/{3}", "Mozilla/5.0 ({0}; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.132 Safari/537.36", "Mozilla/5.0 ({0}; Win64; x64; rv:69.0) Gecko/20100101 Firefox/69.0", "Mozilla/5.0 ({0}; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36 Edge/18.18362", "Mozilla/5.0 ({0}; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Brave Chrome/76.0.3809.132 Safari/537.36", "Mozilla/5.0 ({0}; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.34 Safari/537.36 Edg/78.0.276.11", "Mozilla/5.0 (Linux; U; {0}; SM-J710F Build/M1AJQ; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/77.0.3865.73 Mobile Safari/537.36 OPR/44.1.2254.143214", "Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)", "Mozilla/5.0 (compatible; Bingbot/2.0; +http://www.bing.com/bingbot.htm)", "Mozilla/5.0 (compatible; Yahoo! Slurp; http://help.yahoo.com/help/us/ysearch/slurp)", "DuckDuckBot/1.0; (+http://duckduckgo.com/duckduckbot.html)", "Mozilla/5.0 (compatible; Baiduspider/2.0; +http://www.baidu.com/search/spider.html)", "Mozilla/5.0 (compatible; YandexBot/3.0; +http://yandex.com/bots)", "Sogou Pic Spider/3.0( http://www.sogou.com/docs/help/webmasters.htm#07)", "Sogou head spider/3.0( http://www.sogou.com/docs/help/webmasters.htm#07)", "Sogou web spider/4.0(+http://www.sogou.com/docs/help/webmasters.htm#07)", "Sogou Orion spider/3.0( http://www.sogou.com/docs/help/webmasters.htm#07)", "Sogou-Test-Spider/4.0 (compatible; MSIE 5.5; Windows 98)", "Mozilla/5.0 (compatible; Konqueror/3.5; Linux) KHTML/3.5.5 (like Gecko) (Exabot-Thumbnails)", "Mozilla/5.0 (compatible; Exabot/3.0; +http://www.exabot.com/go/robot)", "facebookexternalhit/{0} (+http://www.facebook.com/externalhit_uatext.php)", "ia_archiver (+http://www.alexa.com/site/help/webmasters; crawler@alexa.com)" };

        public static string InternetExplorer()
        {
            string windowsVersion = RandomWindowsVersion();

            string version = string.Empty;
            string trident = string.Empty;

            #region Генерация случайной версии

            if (windowsVersion.Contains("NT 5.1"))
            {
                version = "9.0";
                trident = "5.0";
            }
            else if (windowsVersion.Contains("NT 6.0"))
            {
                version = "9.0";
                trident = "5.0";
            }
            else
            {
                version = "11.0";
                trident = "7.0";
            }

            #endregion

            return string.Format(
                UserAgents[0],
                windowsVersion, trident, version);
        }

        public static string Opera()
        {
            string windowsVersion = RandomWindowsVersion();

            string chromeVersion = string.Empty;
            string operaVersion = string.Empty;
            string systemType = string.Empty;

            #region Генерация случайной версии

            if (windowsVersion.Contains("NT 5.1") || windowsVersion.Contains("NT 6.0"))
            {
                chromeVersion = "49.0.2623.112";
                operaVersion = "36.0.2130.80";
                systemType = "WOW64";
            }
            else
            {
                systemType = "Win64; x64";
                switch (new Random().Next(2))
                {
                    case 0:
                        chromeVersion = "76.0.3809.132";
                        operaVersion = "63.0.3368.71";
                        break;

                    case 1:
                        chromeVersion = "76.0.3809.132";
                        operaVersion = "63.0.3368.54789";
                        break;
                }
            }

            #endregion

            return string.Format(
                UserAgents[1],
                windowsVersion, systemType, chromeVersion, operaVersion);
        }

        public static string Chrome()
        {
            string windowsVersion = RandomWindowsVersion();

            return string.Format(
                UserAgents[2],
                windowsVersion);
        }

        public static string Firefox()
        {
            string windowsVersion = RandomWindowsVersion();

            return string.Format(
                UserAgents[3],
                windowsVersion);
        }

        public static string Edge()
        {
            string windowsVersion = RandomWindowsVersion();

            return string.Format(
                UserAgents[4],
                windowsVersion);
        }

        public static string Brave()
        {
            string windowsVersion = RandomWindowsVersion();

            return string.Format(UserAgents[4],
                windowsVersion);
        }

        public static string ChromiumEdge()
        {
            string windowsVersion = RandomWindowsVersion();

            return string.Format(UserAgents[5],
                windowsVersion);
        }

        public static string OperaMini()
        {
            string androidVersion = RandomAndroidVersion();

            return string.Format(UserAgents[6],
                androidVersion);
        }

        public static string Googlebot()
        {
            return string.Format(UserAgents[7]);
        }

        public static string Bingbot()
        {
            return string.Format(UserAgents[8]);
        }

        public static string Yahoobot()
        {
            return string.Format(UserAgents[9]);
        }

        public static string Duckduckbot()
        {
            return string.Format(UserAgents[10]);
        }

        public static string Baiduspider()
        {
            return string.Format(UserAgents[11]);
        }

        public static string Yandexbot()
        {
            return string.Format(UserAgents[12]);
        }

        public static string SogouPicspider()
        {
            return string.Format(UserAgents[13]);
        }

        public static string Sogouheadspider()
        {
            return string.Format(UserAgents[14]);
        }

        public static string Sogouwebspider()
        {
            return string.Format(UserAgents[15]);
        }

        public static string SogouOrionspider()
        {
            return string.Format(UserAgents[16]);
        }

        public static string SogouTestspider()
        {
            return string.Format(UserAgents[17]);
        }

        public static string Konqueror()
        {
            return string.Format(UserAgents[18]);
        }

        public static string Exabot()
        {
            return string.Format(UserAgents[19]);
        }

        public static string FacebookExtHit()
        {
            string version = string.Empty;
            switch (new Random().Next(2))
            {
                case 0:
                    version = "1.0";
                    break;

                case 1:
                    version = "1.1";
                    break;
            }

            return string.Format(UserAgents[20], version);
        }

        public static string Alexabot()
        {
            return string.Format(UserAgents[21]);
        }

        public static string Random()
        {
            return UserAgents[new Random().Next(UserAgents.Length)];
        }

        private static string RandomWindowsVersion()
        {
            string windowsVersion = "Windows NT ";

            switch (new Random().Next(6))
            {
                case 0:
                    windowsVersion += "5.1"; // Windows XP
                    break;

                case 1:
                    windowsVersion += "6.0"; // Windows Vista
                    break;

                case 2:
                    windowsVersion += "6.1"; // Windows 7
                    break;

                case 3:
                    windowsVersion += "6.2"; // Windows 8
                    break;

                case 4:
                    windowsVersion += "6.3"; // Windows 8.1
                    break;

                case 5:
                    windowsVersion += "10.0"; // Windows 10
                    break;
            }

            return windowsVersion;
        }

        private static string RandomAndroidVersion()
        {
            string androidVersion = "Android ";

            switch (new Random().Next(28))
            {
                case 0:
                    androidVersion += "1.0";
                    break;

                case 1:
                    androidVersion += "1.1"; // Petit Four
                    break;

                case 2:
                    androidVersion += "1.5"; // Cupcake
                    break;

                case 3:
                    androidVersion += "1.6"; // Donut
                    break;

                case 4:
                    androidVersion += "2.0"; // Eclair
                    break;

                case 5:
                    androidVersion += "2.1"; // Eclair
                    break;

                case 6:
                    androidVersion += "2.2"; // Froyo
                    break;

                case 7:
                    androidVersion += "2.2.3"; // Froyo
                    break;

                case 8:
                    androidVersion += "2.3"; // Gingerbread
                    break;

                case 9:
                    androidVersion += "2.3.7"; // Gingerbread
                    break;

                case 10:
                    androidVersion += "3.0"; // Honeycomb
                    break;

                case 11:
                    androidVersion += "3.2.6"; // Honeycomb
                    break;

                case 12:
                    androidVersion += "4.0"; // Ice Cream Sandwich
                    break;

                case 13:
                    androidVersion += "4.0.4"; // Ice Cream Sandwich
                    break;

                case 14:
                    androidVersion += "4.1"; // Jelly Bean
                    break;

                case 15:
                    androidVersion += "4.3.1"; // Jelly Bean
                    break;

                case 16:
                    androidVersion += "4.4"; // KitKat
                    break;

                case 17:
                    androidVersion += "4.4.4"; // KitKat
                    break;

                case 18:
                    androidVersion += "5.0"; // Lollipop
                    break;

                case 19:
                    androidVersion += "5.1.1"; // Lollipop
                    break;

                case 20:
                    androidVersion += "6.0"; // Marshmallow
                    break;

                case 21:
                    androidVersion += "6.0.1"; // Marshmallow
                    break;

                case 22:
                    androidVersion += "7.0"; // Nougat
                    break;

                case 23:
                    androidVersion += "7.1.2"; // Nougat
                    break;

                case 24:
                    androidVersion += "8.0"; // Oreo
                    break;

                case 25:
                    androidVersion += "8.1"; // Oreo
                    break;

                case 26:
                    androidVersion += "9.0"; // Pie
                    break;

                case 27:
                    androidVersion += "10.0"; // Android 10
                    break;
            }

            return androidVersion;
        }
    }
}
