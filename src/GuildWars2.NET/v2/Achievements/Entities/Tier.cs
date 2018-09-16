using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Achievements.Entities
{
    public class Tier
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("points")]
        public int Points { get; set; }
    }
}
