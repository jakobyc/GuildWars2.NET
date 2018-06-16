using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.Core.v2.Characters.Entities
{
    [DataContract]
    public class CharacterRecipes
    {
        [DataMember(Name = "recipes")]
        public ICollection<int> Ids { get; set; }
    }
}
