using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    public class WvWStats
    {
        [JsonProperty("red")]
        public int Red { get; set; }
        [JsonProperty("blue")]
        public int Blue { get; set; }
        [JsonProperty("green")]
        public int Green { get; set; }
    }
}
