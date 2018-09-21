using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Guilds.Entities
{
    public partial class GuildUpgrade
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("build_time")]
        public long BuildTime { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("required_level")]
        public long RequiredLevel { get; set; }

        [JsonProperty("experience")]
        public long Experience { get; set; }

        [JsonProperty("prerequisites")]
        public long[] Prerequisites { get; set; }

        [JsonProperty("bag_max_items")]
        public long BagMaxItems { get; set; }

        [JsonProperty("bag_max_coins")]
        public long BagMaxCoins { get; set; }

        [JsonProperty("costs")]
        public Cost[] Costs { get; set; }
    }

    public partial class Cost
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemId { get; set; }
    }

}
