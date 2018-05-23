﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Characters.DTOs
{
    [DataContract]
    public class EquipmentStats
    {
        [DataMember(Name="id")]
        public int Id { get; set; }

        [DataMember(Name = "attributes")]
        public Attributes Attributes { get; set; } 
    }
}