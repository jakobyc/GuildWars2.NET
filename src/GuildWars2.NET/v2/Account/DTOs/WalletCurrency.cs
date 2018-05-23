﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Account.DTOs
{
    [DataContract]
    public class WalletCurrency : IRetrievable
    {
        [DataMember(Name="id")]
        public int Id { get; set; }
        [DataMember(Name = "value")]
        public int Value { get; set; }

        public string Endpoint { get; private set; }

        public WalletCurrency()
        {
            this.Endpoint = "account/wallet";
        }
    }
}