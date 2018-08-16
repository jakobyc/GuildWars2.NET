using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Achievements.Entities
{
    [DataContract]
    public class Tier
    {
        [DataMember(Name = "count")]
        public int Count { get; set; }
        [DataMember(Name = "points")]
        public int Points { get; set; }
    }
}
