using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Core.Serialization.JSON;

namespace GuildWars2.NET.Core.v2.Characters.DTOs
{
    [DataContract]
    public class DisciplineInfo
    {
        [DataMember(Name = "discipline")]
        public string Discipline { get; set; }

        [DataMember(Name = "rating")]
        public int Rating { get; set; }

        [DataMember(Name = "active")]
        public bool Active { get; set; }
    }
}