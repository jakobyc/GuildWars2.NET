using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class Pet
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("skills")]
        public Skill[] Skills { get; set; }
    }

    public class Skill
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
