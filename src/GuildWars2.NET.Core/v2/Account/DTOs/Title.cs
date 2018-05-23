﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Core.Serialization.JSON;

namespace GuildWars2.NET.Core.v2.Account.DTOs
{
    [DataContract]
    public class Title : IRetrievable
    {
        public string Endpoint { get; private set; }

        public Title()
        {
            this.Endpoint = "account/titles";
        }
    }
}