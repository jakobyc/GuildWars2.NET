using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Characters.DTOs
{
    [DataContract]
    public class Inventory : IRetrievable
    {
        [DataMember(Name = "bags")]
        public ICollection<InventoryBag> Bags { get; set; }

        public string Endpoint { get; private set; }

        public Inventory(string characterName)
        {
            this.Endpoint = string.Format("characters/{0}/inventory", characterName);
        }
    }
}