using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class Race
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("skills")]
        public string[] Skills { get; set; }
    }
}
