﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Account.Entities
{
    public class Mastery
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
    }
}
