using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    [DataContract]
    public class WvWStats
    {
        [DataMember(Name = "red")]
        public int Red { get; set; }
        [DataMember(Name = "blue")]
        public int Blue { get; set; }
        [DataMember(Name = "green")]
        public int Green { get; set; }
    }
}
