using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    public class LeaderboardItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("scores")]
        public Score[] Scores { get; set; }
    }

    public class Score
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
