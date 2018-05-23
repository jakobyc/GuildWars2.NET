using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.Core.v2.Characters.DTOs
{
    [DataContract]
    public class CharacterSAB : IRetrievable
    {
        [DataMember(Name = "zones")]
        public ICollection<Zone> Zones { get; set; }
        [DataMember(Name = "unlocks")]
        public ICollection<Unlock> Unlocks { get; set; }
        [DataMember(Name = "songs")]
        public ICollection<Song> Songs { get; set; }

        public string Endpoint { get; private set; }

        public CharacterSAB(string characterName)
        {
            this.Endpoint = string.Format("characters/{0}/sab", characterName);
        }

        [DataContract]
        public class Zone
        {
            [DataMember(Name = "id")]
            public int Id { get; set; }
            [DataMember(Name = "mode")]
            public string Mode { get; set; }
            [DataMember(Name = "world")]
            public int World { get; set; }
            [DataMember(Name = "zone")]
            public int ZoneNumber { get; set; }
        }

        [DataContract]
        public class Unlock
        {
            [DataMember(Name = "id")]
            public int Id { get; set; }
            [DataMember(Name = "name")]
            public string Name { get; set; }
        }

        [DataContract]
        public class Song
        {
            [DataMember(Name = "id")]
            public int Id { get; set; }
            [DataMember(Name = "name")]
            public string Name { get; set; }
        }
    }
}
