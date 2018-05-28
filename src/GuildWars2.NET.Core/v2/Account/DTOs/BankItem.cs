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
    public class BankItem
    {
        [DataMember(Name = "upgrades")]
        public ICollection<string> Upgrades { get; set; }
        [DataMember(Name = "infusions")]
        public ICollection<string> Infusions { get; set; }

        [DataMember(Name = "binding")]
        public string Binding { get; set; }
        [DataMember(Name = "bound_to")]
        public string BoundTo { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "count")]
        public int Count { get; set; }
        [DataMember(Name = "skin")]
        public int Skin { get; set; }
        [DataMember(Name = "charges")]
        public int Charges { get; set; }
    }
}
