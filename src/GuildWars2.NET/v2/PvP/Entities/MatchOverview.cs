using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    public class MatchOverview
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("worlds")]
        public WvWStats WorldIds { get; set; }

        [JsonProperty("all_worlds")]
        public AllWorlds AllWorldsIds { get; set; }

        public class AllWorlds
        {
            [JsonProperty("red")]
            public ICollection<int> Red { get; set; }
            [JsonProperty("blue")]
            public ICollection<int> Blue { get; set; }
            [JsonProperty("green")]
            public ICollection<int> Green { get; set; }
        }
    }
}
