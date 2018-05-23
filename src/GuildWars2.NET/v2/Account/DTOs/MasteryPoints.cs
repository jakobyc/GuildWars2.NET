using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Account.DTOs
{
    [DataContract]
    public class MasteryPoints : IRetrievable
    {
        [DataMember(Name = "totals")]
        public ICollection<MasteryPointTotal> Totals { get; set; }

        [DataMember(Name = "unlocked")]
        public ICollection<int> Unlocked { get; set; }

        public string Endpoint { get; set; }

        public MasteryPoints()
        {
            this.Endpoint = "account/mastery/points";
        }
    }
}
