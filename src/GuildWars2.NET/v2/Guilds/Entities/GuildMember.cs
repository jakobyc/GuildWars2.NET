using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Guilds.Entities
{
    public class GuildMember
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("joined")]
        public DateTimeOffset Joined { get; set; }
    }

}
