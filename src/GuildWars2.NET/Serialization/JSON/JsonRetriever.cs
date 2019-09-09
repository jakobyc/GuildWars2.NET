using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace GuildWars2.NET.Serialization.JSON
{
    public class JsonRetriever
    {
        // TODO: Make HttpClient a singleton. Right now, every repository will instantiate a new jsonRetriever, and
        // therefore a new HttpClient, when there should only be one HttpClient.
        private readonly HttpClient client;
        private const string baseUrl = "https://api.guildwars2.com/v2/";

        public JsonRetriever()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri(baseUrl)
            };
        }
        public string GetJson(string endpoint)
        {
            return client.GetStringAsync(endpoint).Result;
        }

        public async Task<string> GetJsonAsync(string endpoint)
        {
            return await client.GetStringAsync(endpoint);
        }
    }
}
