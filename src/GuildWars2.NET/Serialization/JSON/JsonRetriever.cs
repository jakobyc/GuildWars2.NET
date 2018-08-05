using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace GuildWars2.NET.Core.Serialization.JSON
{
    public class JsonRetriever
    {
        private const string baseUrl = "https://api.guildwars2.com/v2/";

        public string GetJson(string endpoint)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString($"{baseUrl}{endpoint}");
            }
        }
    }
}
