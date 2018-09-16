using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class BackstoryAnswer
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("journal")]
        public string Journal { get; set; }

        [JsonProperty("professions")]
        public ICollection<string> Professions { get; set; }
        [JsonProperty("races")]
        public ICollection<string> Races { get; set; }

        [JsonProperty("question")]
        public int Question { get; set; }

    }
}
