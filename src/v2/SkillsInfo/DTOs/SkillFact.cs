using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.SkillsInfo.DTOs
{
    [DataContract]
    public class SkillFact
    {
        [DataMember(Name = "text")]
        public string Text { get; set; }
        [DataMember(Name = "icon")]
        public string Icon { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}
