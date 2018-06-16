using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.Core.v2.Account.Entities
{
    [DataContract]
    public class MasteryPoints
    {
        [DataMember(Name = "totals")]
        public ICollection<MasteryPointTotal> Totals { get; set; }

        [DataMember(Name = "unlocked")]
        public ICollection<int> Unlocked { get; set; }
    }
}
