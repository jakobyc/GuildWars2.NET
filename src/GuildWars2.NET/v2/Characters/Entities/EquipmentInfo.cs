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
    public class EquipmentInfo
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "skin")]
        public int Skin { get; set; }
        [DataMember(Name = "charges")]
        public int Charges { get; set; }

        [DataMember(Name = "slot")]
        public string Slot { get; set; }
        [DataMember(Name = "binding")]
        public string Binding { get; set; }
        [DataMember(Name = "bound_to")]
        public string BoundTo { get; set; }

        [DataMember(Name = "infusions")]
        public ICollection<string> InfusionIDs { get; set; }
        [DataMember(Name = "upgrades")]
        public ICollection<string> UpgradesIDs { get; set; }
        [DataMember(Name = "dyes")]
        public ICollection<string> Dyes { get; set; }

        [DataMember(Name = "stats")]
        public EquipmentStats Stats { get; set; }
    }
}