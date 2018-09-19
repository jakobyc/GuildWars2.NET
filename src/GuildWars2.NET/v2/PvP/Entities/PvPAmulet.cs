using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    public class PvPAmulet
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }
    }

    public partial class Attributes
    {
        [JsonProperty("Vitality")]
        public int Vitality { get; set; }

        [JsonProperty("Power")]
        public int Power { get; set; }

        [JsonProperty("Precision")]
        public int Precision { get; set; }
    }
}
