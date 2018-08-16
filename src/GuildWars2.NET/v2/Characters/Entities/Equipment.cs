using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Characters.Entities
{
    [DataContract]
    public class Equipment
    {
        [DataMember(Name = "equipment")]
        public ICollection<EquipmentInfo> EquipmentInfo { get; set; }
    }
}