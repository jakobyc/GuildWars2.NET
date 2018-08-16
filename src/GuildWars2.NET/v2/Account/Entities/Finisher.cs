using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Account.Entities
{
    [DataContract]
    public class Finisher
    {
        [DataMember(Name="id")]
        public int Id { get; set; }
        [DataMember(Name = "quantity")]
        public int Quantity { get; set; }

        [DataMember(Name = "permanent")]
        public bool Permanent { get; set; }
    }
}
