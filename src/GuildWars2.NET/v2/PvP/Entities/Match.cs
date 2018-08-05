using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    /// <summary>
    /// WvW Match
    /// </summary>
    [DataContract]
    public class Match
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "start_time")]
        public string StartTime { get; set; }
        [DataMember(Name = "end_time")]
        public string EndTime { get; set; }

        [DataMember(Name = "scores")]
        public WvWStats Scores { get; set; }

        [DataMember(Name = "worlds")]
        public WvWStats WorldIds { get; set; }

        [DataMember(Name = "all_worlds")]
        public AllWorlds AllWorldsIds { get; set; }

        [DataMember(Name = "deaths")]
        public WvWStats Deaths { get; set; }

        [DataMember(Name = "kills")]
        public WvWStats Kills { get; set; }

        [DataMember(Name = "maps")]
        public ICollection<Map> Maps { get; set; }

        [DataContract]
        public class AllWorlds
        {
            [DataMember(Name = "red")]
            public ICollection<int> Red { get; set; }
            [DataMember(Name = "blue")]
            public ICollection<int> Blue { get; set; }
            [DataMember(Name = "green")]
            public ICollection<int> Green { get; set; }
        }

        [DataContract]
        public class Bonus
        {
            [DataMember(Name = "type")]
            public string Type { get; set; }
            [DataMember(Name = "owner")]
            public string Owner { get; set; }
        }

        [DataContract]
        public class Objective
        {
            [DataMember(Name = "id")]
            public string Id { get; set; }
            [DataMember(Name = "type")]
            public string Type { get; set; }
            [DataMember(Name = "owner")]
            public string Owner { get; set; }
            [DataMember(Name = "last_flipped")]
            public string LastFlipped { get; set; }
            [DataMember(Name = "claimed_by")]
            public string ClaimedBy { get; set; }
            [DataMember(Name = "claimed_at")]
            public string ClaimedAt { get; set; }
            [DataMember(Name = "points_tick")]
            public int PointsTick { get; set; }
            [DataMember(Name = "points_capture")]
            public int PointsCapture { get; set; }
            [DataMember(Name = "guild_upgrades")]
            public ICollection<int> GuildUpgrades { get; set; }
            [DataMember(Name = "yaks_delivered")]
            public int YaksDelivered { get; set; }
        }

        [DataContract]
        public class Map
        {
            [DataMember(Name = "id")]
            public int Id { get; set; }
            [DataMember(Name = "type")]
            public string Type { get; set; }
            [DataMember(Name = "scores")]
            public WvWStats Scores { get; set; }
            [DataMember(Name = "bonuses")]
            public ICollection<Bonus> Bonuses { get; set; }
            [DataMember(Name = "objectives")]
            public ICollection<Objective> Objectives { get; set; }
            [DataMember(Name = "deaths")]
            public WvWStats Deaths { get; set; }
            [DataMember(Name = "kills")]
            public WvWStats Kills { get; set; }
        }
    }
}
