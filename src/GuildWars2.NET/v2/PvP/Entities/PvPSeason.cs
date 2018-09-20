using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    public class PvPSeason
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public DateTimeOffset Start { get; set; }

        [JsonProperty("end")]
        public DateTimeOffset End { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("divisions")]
        public Division[] Divisions { get; set; }

        [JsonProperty("leaderboards")]
        public Leaderboards Leaderboards { get; set; }
    }

    public class Division
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("flags")]
        public string[] Flags { get; set; }

        [JsonProperty("large_icon")]
        public Uri LargeIcon { get; set; }

        [JsonProperty("small_icon")]
        public Uri SmallIcon { get; set; }

        [JsonProperty("pip_icon")]
        public Uri PipIcon { get; set; }

        [JsonProperty("tiers")]
        public DivisionTier[] Tiers { get; set; }
    }

    public class DivisionTier
    {
        [JsonProperty("points")]
        public int Points { get; set; }
    }

    public class Leaderboards
    {
        [JsonProperty("legendary")]
        public Legendary Legendary { get; set; }

        [JsonProperty("guild")]
        public Guild Guild { get; set; }
    }

    public class Guild
    {
        [JsonProperty("settings")]
        public GuildSettings Settings { get; set; }

        [JsonProperty("scorings")]
        public Scoring[] Scorings { get; set; }
    }

    public class Scoring
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ordering")]
        public string Ordering { get; set; }
    }

    public class GuildSettings
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("duration")]
        public object Duration { get; set; }

        [JsonProperty("scoring")]
        public string Scoring { get; set; }

        [JsonProperty("tiers")]
        public GuildTier[] Tiers { get; set; }
    }

    public class GuildTier
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("range")]
        public int[] Range { get; set; }
    }

    public class Legendary
    {
        [JsonProperty("settings")]
        public LegendarySettings Settings { get; set; }

        [JsonProperty("scorings")]
        public Scoring[] Scorings { get; set; }
    }

    public class LegendarySettings
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("duration")]
        public object Duration { get; set; }

        [JsonProperty("scoring")]
        public string Scoring { get; set; }

        [JsonProperty("tiers")]
        public Tier[] Tiers { get; set; }
    }

    public class Tier
    {
        [JsonProperty("range")]
        public double[] Range { get; set; }
    }
}
