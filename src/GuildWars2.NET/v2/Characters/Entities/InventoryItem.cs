using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GuildWars2.NET.Core.v2.Characters.Entities
{
    [DataContract]
    public class InventoryItem
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "count")]
        public int Count { get; set; }
        [DataMember(Name = "skin")]
        public int Skin { get; set; }

        [DataMember(Name = "binding")]
        public string Binding { get; set; }
        [DataMember(Name = "bound_to")]
        public string BoundTo { get; set; }

        [DataMember(Name = "infusions")]
        public ICollection<string> InfusionIDs { get; set; }
        [DataMember(Name = "upgrades")]
        public ICollection<string> UpgradeIDs { get; set; }

        [DataMember(Name = "stats")]
        public EquipmentStats Stats { get; set; }
    }
}