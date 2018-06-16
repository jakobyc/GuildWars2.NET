using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Core.Serialization.JSON;

namespace GuildWars2.NET.Core.v2.Characters.Entities
{
    [DataContract]
    public class Inventory
    {
        [DataMember(Name = "bags")]
        public ICollection<InventoryBag> Bags { get; set; }
    }
}