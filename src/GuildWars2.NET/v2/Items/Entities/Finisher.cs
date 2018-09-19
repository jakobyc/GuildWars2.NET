﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Items.Entities
{
    public class Finisher
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("unlock_details")]
        public string UnlockDetails { get; set; }

        [JsonProperty("unlock_items")]
        public string[] UnlockItems { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
