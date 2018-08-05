﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    [DataContract]
    public class MatchScores
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "scores")]
        public WvWStats Scores { get; set; }

        [DataMember(Name = "maps")]
        public ICollection<Map> Maps { get; set; }

        [DataContract]
        public class Map
        {
            [DataMember(Name = "id")]
            public int Id { get; set; }

            [DataMember(Name = "type")]
            public string Type { get; set; }

            [DataMember(Name = "scores")]
            public WvWStats Scores { get; set; }
        }
    }
}
