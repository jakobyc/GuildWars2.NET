﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.Serialization.JSON
{
    public class JsonRetriever
    {
        private const string requestUrl = "https://api.guildwars2.com/v2/";

        public string GetJson(string endpoint)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(string.Format("{0}{1}", requestUrl, endpoint));
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
    }
}