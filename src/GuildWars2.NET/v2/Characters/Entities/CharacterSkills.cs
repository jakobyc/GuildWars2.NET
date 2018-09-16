﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class CharacterSkills
    {
        [JsonProperty("skills")]
        public SkillInfo SkillsInformation { get; set; }
    }
}