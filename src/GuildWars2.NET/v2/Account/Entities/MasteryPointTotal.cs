using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Account.Entities
{
    public class MasteryPointTotal
    {
        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("spent")]
        public int Spent { get; set; }
        [JsonProperty("earned")]
        public int Earned { get; set; }
    }
}
