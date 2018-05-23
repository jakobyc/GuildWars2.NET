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
    public class Cat : IRetrievable
    {
        [DataMember(Name="id")]
        public int Id { get; set; }

        [DataMember(Name = "hint")]
        public string Hint { get; set; }

        public string Endpoint { get; private set; }

        public Cat()
        {
            this.Endpoint = "account/home/cats";
        }
    }
}
