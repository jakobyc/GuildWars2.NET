using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    /// <summary>
    /// WvW Guild Stats
    /// </summary>
    [DataContract]
    public class GuildStats
    {
        [DataMember(Name = "guild_id")]
        public string GuildId { get; set; }

        [DataMember(Name = "deaths")]
        public WvWStats Deaths { get; set; }
        [DataMember(Name = "kills")]
        public WvWStats Kills { get; set; }

        [DataMember(Name = "wilson")]
        public decimal Wilson { get; set; }
    }
}
