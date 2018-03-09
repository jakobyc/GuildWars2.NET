using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.SkillsInfo.DTOs
{
    [DataContract]
    public class TraitedSkillFact : SkillFact
    {
        [DataMember(Name = "requires_trait")]
        public int RequiresTrait { get; set; }
        [DataMember(Name = "overrides")]
        public int Overrides { get; set; }
    }
}
