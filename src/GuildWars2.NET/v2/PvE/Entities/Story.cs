using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class Story
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("season")]
        public string Season { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("timeline")]
        public string Timeline { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("races")]
        public ICollection<string> Races { get; set; }

        [JsonProperty("chapters")]
        public ICollection<Chapter> Chapters { get; set; }

        public class Chapter
        {
            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}
