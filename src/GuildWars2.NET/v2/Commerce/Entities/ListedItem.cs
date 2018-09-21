using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Commerce.Entities
{
    public class ListedItem
    {
        [JsonProperty("id")]
        public string ItemId { get; set; }

        [JsonProperty("buys")]
        public Buy[] Buys { get; set; }

        [JsonProperty("sells")]
        public Buy[] Sells { get; set; }
    }

    public class Buy
    {
        [JsonProperty("listings")]
        public int Listings { get; set; }

        [JsonProperty("unit_price")]
        public int UnitPrice { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

}
