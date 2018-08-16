using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.Characters.Entities
{
    [DataContract]
    public class SkillTree
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "spent")]
        public int Spent { get; set; }
        [DataMember(Name = "done")]
        public bool Done { get; set; }
    }
}
