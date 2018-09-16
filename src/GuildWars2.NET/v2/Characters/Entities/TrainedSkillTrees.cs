using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class Training
    {
        [JsonProperty("training")]
        public ICollection<SkillTree> SkillTrees { get; set; }
    }
}
