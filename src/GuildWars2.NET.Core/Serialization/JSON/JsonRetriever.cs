using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using GuildWars2.NET.Core.Serialization.JSON;

namespace GuildWars2.NET.Core.Serialization.JSON
{
    public class JsonRetriever
    {
        private const string requestUrl = "https://api.guildwars2.com/v2/";

        public string GetJson(string endpoint)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString($"{requestUrl}{endpoint}");

            }
        }

        public string GetJson(string endpoint, string accessToken)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(string.Format("{0}{1}?access_token={2}", requestUrl, endpoint, accessToken));
            }
        }

        public string GetJson(IRetrievable obj)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString($"{requestUrl}{obj.Endpoint}");
            }
        }

        public string GetJson(IRetrievable obj, string accessToken)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString($"{requestUrl}{obj.Endpoint}?access_token={accessToken}");
            }
        }

        public string GetJson(IRetrievable obj, string accessToken, string filter)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString($"{requestUrl}{obj.Endpoint}?access_token={accessToken}&{filter}");
            }
        }

        public string GetJson(IRetrievableMock retrievable)
        {
            string endpoint = string.Empty;

            if (!string.IsNullOrEmpty(retrievable.Endpoint))
            {
                endpoint = requestUrl + retrievable.Endpoint;

                if (!string.IsNullOrEmpty(retrievable.AccessToken))
                {
                    retrievable.Parameters.Add($"access_token={retrievable.AccessToken}");
                }

                if (retrievable.Parameters.Count > 0)
                {
                    endpoint += "?";
                    foreach (string parameter in retrievable.Parameters)
                    {
                        endpoint += parameter;
                    }
                }

                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(endpoint);
                }
            }
            else
            {
                throw new Exception("Please provide an endpoint.");
            }
        }
    }
}
