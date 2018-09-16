using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Achievements.Entities
{
    public class Bit
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
