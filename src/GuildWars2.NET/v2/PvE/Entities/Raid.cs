using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class Raid
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("wings")]
        public Wing[] Wings { get; set; }
    }

    public class Wing
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("events")]
        public Event[] Events { get; set; }
    }

    public class Event
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
