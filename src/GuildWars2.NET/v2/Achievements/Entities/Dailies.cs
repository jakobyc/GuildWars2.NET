using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.Achievements.Entities
{
    [DataContract]
    public class Dailies
    {
        [DataMember(Name = "pve")]
        public ICollection<Daily> PvE { get; set; }
        [DataMember(Name = "pvp")]
        public ICollection<Daily> PvP { get; set; }
        [DataMember(Name = "wvw")]
        public ICollection<Daily> WvW { get; set; }
        [DataMember(Name = "fractals")]
        public ICollection<Daily> Fractals { get; set; }
        [DataMember(Name = "special")]
        public ICollection<Daily> Special { get; set; }
    }
}
