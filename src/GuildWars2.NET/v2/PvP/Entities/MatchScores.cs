using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    public class MatchScores
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("scores")]
        public WvWStats Scores { get; set; }

        [JsonProperty("maps")]
        public ICollection<Map> Maps { get; set; }

        public class Map
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("scores")]
            public WvWStats Scores { get; set; }
        }
    }
}
