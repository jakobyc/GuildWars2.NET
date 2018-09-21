using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Commerce.Entities
{
    public class Currency
    {
        [JsonProperty("coins_per_gem")]
        public int CoinsPerGem { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
