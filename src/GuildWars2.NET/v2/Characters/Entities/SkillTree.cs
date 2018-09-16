using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class SkillTree
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("spent")]
        public int Spent { get; set; }
        [JsonProperty("done")]
        public bool Done { get; set; }
    }
}
