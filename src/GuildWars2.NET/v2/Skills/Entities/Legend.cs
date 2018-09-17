using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Skills.Entities
{
    public class Legend
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("swap")]
        public string Swap { get; set; }

        [JsonProperty("heal")]
        public string Heal { get; set; }

        [JsonProperty("elite")]
        public string Elite { get; set; }

        [JsonProperty("utilities")]
        public string[] Utilities { get; set; }
    }
}
