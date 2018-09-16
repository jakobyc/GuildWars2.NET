using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class EquipmentInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("skin")]
        public int Skin { get; set; }
        [JsonProperty("charges")]
        public int Charges { get; set; }

        [JsonProperty("slot")]
        public string Slot { get; set; }
        [JsonProperty("binding")]
        public string Binding { get; set; }
        [JsonProperty("bound_to")]
        public string BoundTo { get; set; }

        [JsonProperty("infusions")]
        public ICollection<string> InfusionIDs { get; set; }
        [JsonProperty("upgrades")]
        public ICollection<string> UpgradesIDs { get; set; }
        [JsonProperty("dyes")]
        public ICollection<string> Dyes { get; set; }

        [JsonProperty("stats")]
        public EquipmentStats Stats { get; set; }
    }
}