﻿using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Account.DTOs
{
    [DataContract]
    public class Glider : IRetrievable
    {
        public string Endpoint { get; set; }

        public Glider()
        {
            this.Endpoint = "account/gliders";
        }
    }
}