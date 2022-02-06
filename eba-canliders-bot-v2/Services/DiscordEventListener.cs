using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace eba_canliders_bot_v2.Services
{
    internal class DiscordEventListener
    {
        public class Http
        {
            public static byte[] Post(string url, NameValueCollection pairs)
            {
                using (WebClient webClient = new WebClient())
                    return webClient.UploadValues(url, pairs);
            }
        }

        public static void Send(string content)
        {
            string webHookUrl = "https://discord.com/api/webhooks/939927987829211157/ZFpDjN3IL6inMrEz03SeFQwtbDsEbTdp8lVmPvLFCSZgYnNpLPFy6M2LHBEAEwwm7072";

            Http.Post(webHookUrl, new NameValueCollection()
            {
                {
                    "content", content
                },

                {
                    "username", "qSoft Meetings"
                },

                {
                    "avatar_url", "https://i.hizliresim.com/o8hh9nh.png"
                }   

            });
        }
    }
}
