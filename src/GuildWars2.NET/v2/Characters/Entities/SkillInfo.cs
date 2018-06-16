using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GuildWars2.NET.Core.v2.Characters.Entities
{
    [DataContract]
    public class SkillInfo
    {
        [DataMember(Name = "pve")]
        public SkillPvE PvE { get; set; }
        [DataMember(Name = "pvp")]
        public SkillPvP PvP { get; set; }
        [DataMember(Name = "wvw")]
        public SkillWvW WvW { get; set; }
    }
}