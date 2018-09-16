using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.Achievements.Entities
{
    public class Dailies
    {
        [JsonProperty("pve")]
        public ICollection<Daily> PvE { get; set; }
        [JsonProperty("pvp")]
        public ICollection<Daily> PvP { get; set; }
        [JsonProperty("wvw")]
        public ICollection<Daily> WvW { get; set; }
        [JsonProperty("fractals")]
        public ICollection<Daily> Fractals { get; set; }
        [JsonProperty("special")]
        public ICollection<Daily> Special { get; set; }
    }
}
