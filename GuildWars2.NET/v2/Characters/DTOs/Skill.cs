﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Characters.DTOs
{
    [DataContract]
    public abstract class Skill : ISkill
    {
        [DataMember(Name = "heal")]
        public int HealId { get; set; }
        [DataMember(Name = "elite")]
        public int EliteId { get; set; }

        [DataMember(Name = "utilities")]
        public ICollection<int> UtilitiesIDs { get; set; }
    }
}
