using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.Core.v2.Characters.DTOs
{
    [DataContract]
    public class Training
    {
        [DataMember(Name = "training")]
        public ICollection<SkillTree> SkillTrees { get; set; }
    }
}
