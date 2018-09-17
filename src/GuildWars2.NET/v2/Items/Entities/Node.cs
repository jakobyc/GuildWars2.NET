using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Items.Entities
{
    public class Node
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
