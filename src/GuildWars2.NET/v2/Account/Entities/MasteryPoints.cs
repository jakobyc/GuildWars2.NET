using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Account.Entities
{
    public class MasteryPoints
    {
        [JsonProperty("totals")]
        public ICollection<MasteryPointTotal> Totals { get; set; }

        [JsonProperty("unlocked")]
        public ICollection<string> Unlocked { get; set; }
    }
}
