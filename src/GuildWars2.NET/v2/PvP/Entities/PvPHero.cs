using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    public class PvPHero
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("overlay")]
        public Uri Overlay { get; set; }

        [JsonProperty("underlay")]
        public Uri Underlay { get; set; }

        [JsonProperty("skins")]
        public Skin[] Skins { get; set; }
    }

    public partial class Skin
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("unlock_items")]
        public string[] UnlockItems { get; set; }
    }

    public partial class Stats
    {
        [JsonProperty("offense")]
        public int Offense { get; set; }

        [JsonProperty("defense")]
        public int Defense { get; set; }

        [JsonProperty("speed")]
        public int Speed { get; set; }
    }
}
