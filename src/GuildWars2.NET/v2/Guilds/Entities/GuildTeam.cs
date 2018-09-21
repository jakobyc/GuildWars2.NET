using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Guilds.Entities
{
    /// <summary>
    /// Guild PvP Team
    /// </summary>
    public class GuildTeam
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("members")]
        public Member[] Members { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("aggregate")]
        public Aggregate Aggregate { get; set; }

        [JsonProperty("ladders")]
        public Ladders Ladders { get; set; }

        [JsonProperty("games")]
        public Game[] Games { get; set; }

        [JsonProperty("seasons")]
        public Season[] Seasons { get; set; }
    }

    public class Aggregate
    {
        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("desertions")]
        public int Desertions { get; set; }

        [JsonProperty("byes")]
        public int Byes { get; set; }

        [JsonProperty("forfeits")]
        public int Forfeits { get; set; }
    }

    public class Game
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

        [JsonProperty("scores")]
        public Scores Scores { get; set; }

        [JsonProperty("rating_type")]
        public string RatingType { get; set; }
    }

    public class Scores
    {
        [JsonProperty("red")]
        public int Red { get; set; }

        [JsonProperty("blue")]
        public int Blue { get; set; }
    }

    public class Ladders
    {
        [JsonProperty("unranked")]
        public Aggregate Unranked { get; set; }
    }

    public class Member
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class Season
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }
    }
}
