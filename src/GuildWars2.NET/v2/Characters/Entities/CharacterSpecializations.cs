using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class CharacterSpecializations
    {
        [JsonProperty("specializations")]
        public Specializations Specs { get; set; }
    }
}
