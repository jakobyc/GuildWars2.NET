using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class World
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("population")]
        public string Population { get; set; }
    }
}
