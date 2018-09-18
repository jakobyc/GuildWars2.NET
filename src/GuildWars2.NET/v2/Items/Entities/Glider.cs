using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Items.Entities
{
    public class Glider
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Array of item IDs required to unlock this glider.
        /// </summary>
        [JsonProperty("unlock_items")]
        public string[] UnlockItems { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Array of dye IDs .
        /// </summary>
        [JsonProperty("default_dyes")]
        public string[] DefaultDyes { get; set; }
    }
}
