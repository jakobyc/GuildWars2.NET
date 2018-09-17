using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class Mastery
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("requirement")]
        public string Requirement { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("background")]
        public Uri Background { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("levels")]
        public Level[] Levels { get; set; }
    }

    public class Level
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("instruction")]
        public string Instruction { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("point_cost")]
        public int PointCost { get; set; }

        [JsonProperty("exp_cost")]
        public int ExpCost { get; set; }
    }
}
