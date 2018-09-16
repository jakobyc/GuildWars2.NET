using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class Attributes
    {
        [JsonProperty("Power")]
        public int Power { get; set; }
        [JsonProperty("Precision")]
        public int Precision { get; set; }
        [JsonProperty("Toughness")]
        public int Toughness { get; set; }
        [JsonProperty("Vitality")]
        public int Vitality { get; set; }
        [JsonProperty("Condition Damage")]
        public int ConditionDamage { get; set; }
        [JsonProperty("Condition Duration")]
        public int ConditionDuration { get; set; }
        [JsonProperty("Healing")]
        public int Healing { get; set; }
        [JsonProperty("BoonDuration")]
        public int BoonDuration { get; set; }
        [JsonProperty("CritDamage")]
        public int CriticalDamage { get; set; }
    }
}
