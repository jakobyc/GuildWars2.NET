using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GuildWars2.NET.v2.Account.Entities
{
    [DataContract]
    public class AccountAchievement
    {
        [DataMember(Name = "bits")]
        public ICollection<string> bits { get; set; }

        [DataMember(Name="id")]
        public int Id { get; set; }
        [DataMember(Name = "current")]
        public int Current { get; set; }
        [DataMember(Name = "max")]
        public int Max { get; set; }
        [DataMember(Name = "repeated")]
        public int Repeated { get; set; }

        [DataMember(Name = "done")]
        public bool Done { get; set; }
    }
}
