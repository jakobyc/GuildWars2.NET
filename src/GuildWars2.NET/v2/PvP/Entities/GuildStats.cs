using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    /// <summary>
    /// WvW Guild Stats
    /// </summary>
    public class GuildStats
    {
        [JsonProperty("guild_id")]
        public string GuildId { get; set; }

        [JsonProperty("deaths")]
        public WvWStats Deaths { get; set; }
        [JsonProperty("kills")]
        public WvWStats Kills { get; set; }

        [JsonProperty("wilson")]
        public decimal Wilson { get; set; }
    }
}
