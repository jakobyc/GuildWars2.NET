using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.Characters.Entities
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
