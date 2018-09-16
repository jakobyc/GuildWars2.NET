using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class StorySeason
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        /// <summary>
        /// Collection of story id's associated with the selected Season
        /// </summary>
        [JsonProperty("stories")]
        public ICollection<string> StoryIds { get; set; }
    }
}
