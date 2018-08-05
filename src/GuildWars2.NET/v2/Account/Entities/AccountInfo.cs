﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GuildWars2.NET.Core.v2.Account.Entities
{
    [DataContract]
    public class AccountInfo
    {
        [DataMember(Name="guilds")]
        public ICollection<string> Guilds { get; set; }
        [DataMember(Name = "guild_leader")]
        public ICollection<string> GuildLeaderOf { get; set; }
        [DataMember(Name = "access")]
        public ICollection<string> Access { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "created")]
        public string Created { get; set; }

        [DataMember(Name = "age")]
        public int Age { get; set; }
        [DataMember(Name = "world")]
        public int WorldId { get; set; }
        [DataMember(Name = "fractal_level")]
        public int FractalLevel { get; set; }
        [DataMember(Name = "daily_ap")]
        public int DailyAP { get; set; }
        [DataMember(Name = "monthly_ap")]
        public int MonthlyAP { get; set; }
        [DataMember(Name = "wvw_rank")]
        public int WvwRank { get; set; }

        [DataMember(Name = "commander")]
        public bool Commander { get; set; }
    }
}