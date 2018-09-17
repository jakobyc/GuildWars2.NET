using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Items.Entities
{
    public class ItemStat
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("attributes")]
        public Attribute[] Attributes { get; set; }
    }

    public class Attribute
    {
        [JsonProperty("attribute")]
        public string AttributeAttribute { get; set; }

        [JsonProperty("multiplier")]
        public double Multiplier { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
