using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.Core.v2.Characters.DTOs
{
    [DataContract]
    public class Specializations
    {
        [DataMember(Name = "pve")]
        public ICollection<PvE> PvESpecs { get; set; }
        [DataMember(Name = "pvp")]
        public ICollection<PvP> PvPSpecs { get; set; }
        [DataMember(Name = "wvw")]
        public ICollection<WvW> WvWSpecs { get; set; }

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
    }
}
