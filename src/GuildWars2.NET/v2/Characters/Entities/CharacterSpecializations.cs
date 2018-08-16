using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.Characters.Entities
{
    [DataContract]
    public class CharacterSpecializations
    {
        [DataMember(Name = "specializations")]
        public Specializations Specs { get; set; }
    }
}
