using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Items.Entities
{
    public class Cat
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hint")]
        public string Hint { get; set; }
    }
}
