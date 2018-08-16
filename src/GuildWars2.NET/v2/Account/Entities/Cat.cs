﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Account.Entities
{
    [DataContract]
    public class Cat
    {
        [DataMember(Name="id")]
        public int Id { get; set; }

        [DataMember(Name = "hint")]
        public string Hint { get; set; }
    }
}
