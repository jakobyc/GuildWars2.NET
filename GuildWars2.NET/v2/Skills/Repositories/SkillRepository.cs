﻿using GuildWars2.NET.Data;
using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Skills.Repositories
{
    public class SkillRepository : GW2Repository
    {
        public SkillRepository() : base() { }
        public SkillRepository(JsonDeserializer deserializer, JsonRetriever retriever) : base(deserializer, retriever) { }
    }
}
