using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class CharacterRecipes
    {
        [JsonProperty("recipes")]
        public ICollection<int> Ids { get; set; }
    }
}
