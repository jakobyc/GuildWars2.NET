using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.Core.v2.Characters.DTOs
{
    [DataContract]
    public class CharacterSpecializations : IRetrievable
    {
        [DataMember(Name = "specializations")]
        public Specializations Specs { get; set; }

        public string Endpoint { get; private set; }

        public CharacterSpecializations(string characterName)
        {
            this.Endpoint = string.Format("characters/{0}/specializations", characterName);
        }
    }
}
