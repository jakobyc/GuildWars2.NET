using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Account.DTOs
{
    [DataContract]
    public class SharedInventoryItem : IRetrievable
    {
        [DataMember(Name="id")]
        public int Id { get; set; }
        [DataMember(Name = "count")]
        public int Count { get; set; }

        [DataMember(Name = "binding")]
        public string Binding { get; set; }

        public string Endpoint { get; private set; }

        public SharedInventoryItem()
        {
            this.Endpoint = "account/inventory";
        }
    }
}
