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

        [DataContract]
        public class PvE
        {
            [DataMember(Name = "id")]
            public int Id { get; set; }
            [DataMember(Name = "traits")]
            public ICollection<int> Traits { get; set; }
        }

        [DataContract]
        public class PvP
        {
            [DataMember(Name = "id")]
            public int Id { get; set; }
            [DataMember(Name = "traits")]
            public ICollection<int> Traits { get; set; }
        }

        [DataContract]
        public class WvW
        {
            [DataMember(Name = "id")]
            public int Id { get; set; }
            [DataMember(Name = "traits")]
            public ICollection<int> Traits { get; set; }
        }

        [DataContract]
        public class Specializations
        {
            [DataMember(Name = "pve")]
            public ICollection<PvE> PvE { get; set; }
            [DataMember(Name = "pvp")]
            public ICollection<PvP> PvP { get; set; }
            [DataMember(Name = "wvw")]
            public ICollection<WvW> WvW { get; set; }
        }
    }
}
