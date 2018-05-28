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
    public class Finisher
    {
        [DataMember(Name="id")]
        public int Id { get; set; }
        [DataMember(Name = "quantity")]
        public int Quantity { get; set; }

        [DataMember(Name = "permanent")]
        public bool Permanent { get; set; }
    }
}
