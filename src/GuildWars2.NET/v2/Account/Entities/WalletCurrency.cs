using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Account.Entities
{
    public class WalletCurrency
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}