using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.Core.v2.Characters.Entities
{
    [DataContract]
    public class CharacterSpecializations
    {
        [DataMember(Name = "specializations")]
        public Specializations Specs { get; set; }
    }
}
