using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Account.Entities
{
    [DataContract]
    public class MasteryPointTotal
    {
        [DataMember(Name = "region")]
        public string Region { get; set; }

        [DataMember(Name = "spent")]
        public int Spent { get; set; }
        [DataMember(Name = "earned")]
        public int Earned { get; set; }
    }
}
