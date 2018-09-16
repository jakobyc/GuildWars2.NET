using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Achievements.Entities
{
    public class Reward
    {
        /// <summary>
        /// If type = Coins, Count property will be populated.
        /// If type = Item, Id and Count properties will be populated.
        /// If type = Mastery, Id and Region properties will be populated.
        /// If type = Title, Id property will be populated.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
