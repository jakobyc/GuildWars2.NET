using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Core.Serialization.JSON;

namespace GuildWars2.NET.Core.v2.Characters.DTOs
{
    [DataContract]
    public class Attributes
    {
        [DataMember(Name = "Power")]
        public int Power { get; set; }
        [DataMember(Name = "Precision")]
        public int Precision { get; set; }
        [DataMember(Name = "Toughness")]
        public int Toughness { get; set; }
        [DataMember(Name = "Vitality")]
        public int Vitality { get; set; }
        [DataMember(Name = "Condition Damage")]
        public int ConditionDamage { get; set; }
        [DataMember(Name = "Condition Duration")]
        public int ConditionDuration { get; set; }
        [DataMember(Name = "Healing")]
        public int Healing { get; set; }
        [DataMember(Name = "BoonDuration")]
        public int BoonDuration { get; set; }
        [DataMember(Name = "CritDamage")]
        public int CriticalDamage { get; set; }
    }
}
