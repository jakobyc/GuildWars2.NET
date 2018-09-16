using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.Misc.Entities
{
    public class Title
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("achievement")]
        public string AchievementId { get; set; }

        [JsonProperty("achievements")]
        public ICollection<string> AchievementIds { get; set; }
    }
}
