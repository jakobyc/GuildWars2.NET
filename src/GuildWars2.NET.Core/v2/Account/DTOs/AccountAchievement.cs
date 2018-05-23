using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Core.Serialization.JSON;

namespace GuildWars2.NET.Core.v2.Account.DTOs
{
    [DataContract]
    public class AccountAchievement : IRetrievable
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

        public string Endpoint { get; private set; }

        public AccountAchievement()
        {
            this.Endpoint = "account/achievements";
        }
    }
}
