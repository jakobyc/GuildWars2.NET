using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    [DataContract]
    public class WvWAbility
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        [DataMember(Name = "ranks")]
        public ICollection<Rank> Ranks { get; set; }

        [DataContract]
        public class Rank
        {
            [DataMember(Name = "cost")]
            public int Cost { get; set; }

            [DataMember(Name = "effect")]
            public string Effect { get; set; }
        }
    }


}
