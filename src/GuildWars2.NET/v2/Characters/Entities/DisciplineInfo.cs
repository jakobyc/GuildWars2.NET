using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class DisciplineInfo
    {
        [JsonProperty("discipline")]
        public string Discipline { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}