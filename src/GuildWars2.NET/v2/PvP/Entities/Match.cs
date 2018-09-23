using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    /// <summary>
    /// WvW Match
    /// </summary>
    public class Match
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("scores")]
        public WvWStats Scores { get; set; }

        [JsonProperty("worlds")]
        public WvWStats WorldIds { get; set; }

        [JsonProperty("all_worlds")]
        public AllWorlds AllWorldsIds { get; set; }

        [JsonProperty("deaths")]
        public WvWStats Deaths { get; set; }

        [JsonProperty("kills")]
        public WvWStats Kills { get; set; }

        [JsonProperty("maps")]
        public ICollection<Map> Maps { get; set; }

        public class AllWorlds
        {
            [JsonProperty("red")]
            public ICollection<int> Red { get; set; }
            [JsonProperty("blue")]
            public ICollection<int> Blue { get; set; }
            [JsonProperty("green")]
            public ICollection<int> Green { get; set; }
        }

        public class Bonus
        {
            [JsonProperty("type")]
            public string Type { get; set; }
            [JsonProperty("owner")]
            public string Owner { get; set; }
        }

        public class Objective
        {
            [JsonProperty("id")]
            public string Id { get; set; }
            [JsonProperty("type")]
            public string Type { get; set; }
            [JsonProperty("owner")]
            public string Owner { get; set; }
            [JsonProperty("last_flipped")]
            public string LastFlipped { get; set; }
            [JsonProperty("claimed_by")]
            public string ClaimedBy { get; set; }
            [JsonProperty("claimed_at")]
            public string ClaimedAt { get; set; }
            [JsonProperty("points_tick")]
            public int PointsTick { get; set; }
            [JsonProperty("points_capture")]
            public int PointsCapture { get; set; }
            [JsonProperty("guild_upgrades")]
            public ICollection<string> GuildUpgrades { get; set; }
            [JsonProperty("yaks_delivered")]
            public int YaksDelivered { get; set; }
        }

        public class Map
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("type")]
            public string Type { get; set; }
            [JsonProperty("scores")]
            public WvWStats Scores { get; set; }
            [JsonProperty("bonuses")]
            public ICollection<Bonus> Bonuses { get; set; }
            [JsonProperty("objectives")]
            public ICollection<Objective> Objectives { get; set; }
            [JsonProperty("deaths")]
            public WvWStats Deaths { get; set; }
            [JsonProperty("kills")]
            public WvWStats Kills { get; set; }
        }
    }
}
