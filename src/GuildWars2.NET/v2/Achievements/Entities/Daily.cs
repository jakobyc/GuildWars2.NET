using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.Achievements.Entities
{
    public class Daily
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("level")]
        public Level LevelRange { get; set; }

        [JsonProperty("required_access")]
        public ICollection<string> RequiredAccess { get; set; }

        public class Level
        {
            [JsonProperty("min")]
            public int Min { get; set; }
            [JsonProperty("max")]
            public int Max { get; set; }
        }
    }
}
