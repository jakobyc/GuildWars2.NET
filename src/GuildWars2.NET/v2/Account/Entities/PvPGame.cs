using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Account.Entities
{
    public class PvPGame
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("map_id")]
        public string MapId { get; set; }

        [JsonProperty("started")]
        public DateTimeOffset Started { get; set; }

        [JsonProperty("ended")]
        public DateTimeOffset Ended { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("profession")]
        public string Profession { get; set; }

        [JsonProperty("rating_type")]
        public string RatingType { get; set; }

        [JsonProperty("scores")]
        public Scores Scores { get; set; }
    }

    public partial class Scores
    {
        [JsonProperty("red")]
        public int Red { get; set; }

        [JsonProperty("blue")]
        public int Blue { get; set; }
    }
}
