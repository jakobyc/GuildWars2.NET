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
    public class MailCarrier : IRetrievable
    {
        public string Endpoint { get; set; }

        public MailCarrier()
        {
            this.Endpoint = "account/mailcarriers";
        }
    }
}
