using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    [DataContract]
    public class MatchOverview
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "start_time")]
        public string StartTime { get; set; }
        [DataMember(Name = "end_time")]
        public string EndTime { get; set; }

        [DataMember(Name = "worlds")]
        public WvWStats WorldIds { get; set; }

        [DataMember(Name = "all_worlds")]
        public AllWorlds AllWorldsIds { get; set; }

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
    }
}
