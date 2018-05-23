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
    public class CraftingInfo : IRetrievable
    {
        [DataMember(Name="crafting")]
        public ICollection<DisciplineInfo> Disciplines { get; set; }

        public string Endpoint { get; private set; }

        public CraftingInfo(string characterName)
        {
            this.Endpoint = string.Format("characters/{0}/crafting", characterName);
        }
    }
}