using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public abstract class CharacterSkill : ISkill
    {
        [JsonProperty("heal")]
        public string HealId { get; set; }
        [JsonProperty("elite")]
        public string EliteId { get; set; }

        [JsonProperty("utilities")]
        public ICollection<string> UtilitiesIDs { get; set; }
    }
}
