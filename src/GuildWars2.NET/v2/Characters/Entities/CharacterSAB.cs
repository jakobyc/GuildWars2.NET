using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class CharacterSAB
    {
        [JsonProperty("zones")]
        public ICollection<Zone> Zones { get; set; }
        [JsonProperty("unlocks")]
        public ICollection<Unlock> Unlocks { get; set; }
        [JsonProperty("songs")]
        public ICollection<Song> Songs { get; set; }

        public class Zone
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("mode")]
            public string Mode { get; set; }
            [JsonProperty("world")]
            public int World { get; set; }
            [JsonProperty("zone")]
            public int ZoneNumber { get; set; }
        }

        public class Unlock
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public class Song
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}
