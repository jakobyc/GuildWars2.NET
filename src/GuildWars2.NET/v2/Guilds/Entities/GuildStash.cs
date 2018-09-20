using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Guilds.Entities
{
    public class GuildStash
    {
        [JsonProperty("upgrade_id")]
        public string UpgradeId { get; set; }
        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }
        [JsonProperty("coins")]
        public int Coins { get; set; }

        [JsonProperty("inventory")]
        public StashInventory[] Inventory { get; set; }

        public class StashInventory
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("count")]
            public int Count { get; set; }
        }
    }
}
