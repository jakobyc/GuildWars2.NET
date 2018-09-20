using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Account.Entities
{
    public class PvPStandings
    {
        [JsonProperty("season_id")]
        public string SeasonId { get; set; }

        [JsonProperty("current")]
        public Current CurrentPips { get; set; }
        [JsonProperty("best")]
        public Best BestPips { get; set; }

        public class Current
        {
            [JsonProperty("division")]
            public string Division { get; set; }
            [JsonProperty("tier")]
            public string Tier { get; set; }

            [JsonProperty("total_points")]
            public int TotalPoints { get; set; }
            [JsonProperty("points")]
            public int Points { get; set; }
            [JsonProperty("repeats")]
            public int Repeats { get; set; }
            [JsonProperty("rating")]
            public int Rating { get; set; }
            [JsonProperty("decay")]
            public int Decay { get; set; }
        }

        public class Best
        {

        }
    }
}
