using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class Dungeon
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("paths")]
        public Path[] Paths { get; set; }
    }

    public class Path
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
