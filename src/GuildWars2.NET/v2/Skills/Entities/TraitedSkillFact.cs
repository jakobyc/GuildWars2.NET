using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Skills.Entities
{
    public class TraitedSkillFact : SkillFact
    {
        [JsonProperty("requires_trait")]
        public int RequiresTrait { get; set; }
        [JsonProperty("overrides")]
        public int Overrides { get; set; }
    }
}
