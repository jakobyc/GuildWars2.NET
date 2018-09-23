using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Achievements.Entities
{
    public class Achievement
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("requirement")]
        public string Requirement { get; set; }
        [JsonProperty("locked_text")]
        public string LockedText { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("point_cap")]
        public int PointCap { get; set; }

        [JsonProperty("flags")]
        public ICollection<string> Flags { get; set; }

        [JsonProperty("tiers")]
        public ICollection<Tier> Tiers { get; set; }

        [JsonProperty("prerequisites")]
        public ICollection<string> Prerequisites { get; set; }

        [JsonProperty("rewards")]
        public ICollection<Reward> Rewards { get; set; }

        [JsonProperty("bits")]
        public ICollection<Bit> Bits { get; set; }
    }
}
