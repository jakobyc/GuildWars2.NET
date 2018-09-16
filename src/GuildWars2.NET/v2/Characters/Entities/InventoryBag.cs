using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class InventoryBag
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("inventory")]
        public ICollection<InventoryItem> Items { get; set; }
    }
}