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
    public class Material : IRetrievable
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "category")]
        public int Category { get; set; }
        [DataMember(Name = "count")]
        public int Count { get; set; }

        public string Endpoint { get; private set; }

        public Material()
        {
            this.Endpoint = "account/materials";
        }
    }
}
