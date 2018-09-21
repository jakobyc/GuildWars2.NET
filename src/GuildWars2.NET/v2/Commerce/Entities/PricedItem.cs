using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Commerce.Entities
{
    public class PricedItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("whitelisted")]
        public bool Whitelisted { get; set; }

        [JsonProperty("buys")]
        public PricingInfo Buys { get; set; }

        [JsonProperty("sells")]
        public PricingInfo Sells { get; set; }
    }

    public class PricingInfo
    {
        /// <summary>
        /// Amount of items being sold/bought.
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// The highest buy order or lowest sell offer price in coins.
        /// </summary>
        [JsonProperty("unit_price")]
        public int UnitPrice { get; set; }
    }
}
