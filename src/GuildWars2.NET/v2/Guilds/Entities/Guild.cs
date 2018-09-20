using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Guilds.Entities
{
    public class Guild
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("emblem")]
        public GuildEmblem Emblem { get; set; }

        public class GuildEmblem
        {
            [JsonProperty("background")]
            public Ground Background { get; set; }

            [JsonProperty("foreground")]
            public Ground Foreground { get; set; }

            [JsonProperty("flags")]
            public string[] Flags { get; set; }
        }

        public class Ground
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("colors")]
            public string[] Colors { get; set; }
        }
    }
}
