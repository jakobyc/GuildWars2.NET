using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    public class MatchStats
    {
        [JsonProperty("id")]
        public string Id { get; set; }


        [JsonProperty("deaths")]
        public WvWStats Deaths { get; set; }
        [JsonProperty("kills")]
        public WvWStats Kills { get; set; }

        [JsonProperty("maps")]
        public ICollection<Map> Maps { get; set; }

        public class Map
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("deaths")]
            public WvWStats Deaths { get; set; }
            [JsonProperty("kills")]
            public WvWStats Kills { get; set; }
        }
    }
}
