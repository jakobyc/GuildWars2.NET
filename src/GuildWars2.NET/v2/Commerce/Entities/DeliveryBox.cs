using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Commerce.Entities
{
    public class DeliveryBox
    {
        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        public class Item
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("count")]
            public int Count { get; set; }
        }
    }
}
