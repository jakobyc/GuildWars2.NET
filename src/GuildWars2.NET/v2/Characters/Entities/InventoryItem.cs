using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class InventoryItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("skin")]
        public int Skin { get; set; }

        [JsonProperty("binding")]
        public string Binding { get; set; }
        [JsonProperty("bound_to")]
        public string BoundTo { get; set; }

        [JsonProperty("infusions")]
        public ICollection<string> InfusionIDs { get; set; }
        [JsonProperty("upgrades")]
        public ICollection<string> UpgradeIDs { get; set; }

        [JsonProperty("stats")]
        public EquipmentStats Stats { get; set; }
    }
}