﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using GuildWars2.NET.Builders.Endpoints;

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
        public string GetJson(IEndpointBuilder builder)
        {
            return client.GetStringAsync(builder.Build()).Result;
        }

        public async Task<string> GetJsonAsync(IEndpointBuilder builder)
        {
            return await client.GetStringAsync(builder.Build());
        }
    }
}
