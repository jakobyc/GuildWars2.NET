using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GuildWars2.NET.v2.Characters.Entities
{
    [DataContract]
    public class InventoryBag
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "size")]
        public int Size { get; set; }

        [DataMember(Name = "inventory")]
        public ICollection<InventoryItem> Items { get; set; }
    }
}