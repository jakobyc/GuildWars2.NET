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
    public class Mastery : IRetrievable
    {
        [DataMember(Name="id")]
        public int Id { get; set; }
        [DataMember(Name = "level")]
        public int Level { get; set; }

        public string Endpoint { get; private set; }

        public Mastery()
        {
            this.Endpoint = "account/masteries";
        }
    }
}