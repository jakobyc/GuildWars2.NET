using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Guilds.Entities
{
    public class GuildTreasury
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("needed_by")]
        public NeededByUpgrade[] NeededBy { get; set; }

        public class NeededByUpgrade
        {
            [JsonProperty("upgrade_id")]
            public string UpgradeId { get; set; }

            [JsonProperty("count")]
            public int Count { get; set; }
        }
    }
}
