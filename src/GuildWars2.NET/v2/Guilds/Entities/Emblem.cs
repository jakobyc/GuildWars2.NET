using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Guilds.Entities
{
    public class Emblem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("layers")]
        public Uri[] Layers { get; set; }
    }
}
