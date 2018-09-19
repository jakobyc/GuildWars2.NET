using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    public class PvPRank
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("finisher_id")]
        public string FinisherId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("min_rank")]
        public int MinRank { get; set; }

        [JsonProperty("max_rank")]
        public int MaxRank { get; set; }

        [JsonProperty("levels")]
        public Level[] Levels { get; set; }
    }

    public class Level
    {
        [JsonProperty("min_rank")]
        public int MinRank { get; set; }

        [JsonProperty("max_rank")]
        public int MaxRank { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }
    }

}
