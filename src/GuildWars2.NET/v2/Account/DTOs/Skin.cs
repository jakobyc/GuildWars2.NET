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
    public class Skin : IRetrievable
    {
        public string Endpoint { get; private set; }

        public Skin()
        {
            this.Endpoint = "account/skins";
        }
    }
}