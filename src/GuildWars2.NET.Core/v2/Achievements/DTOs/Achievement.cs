using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.Core.v2.Achievements.DTOs
{
    [DataContract]
    public class Achievement : IRetrievable
    {
        [DataMember(Name = "icon")]
        public string Icon { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "requirement")]
        public string Requirement { get; set; }
        [DataMember(Name = "locked_text")]
        public string LockedText { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "point_cap")]
        public int PointCap { get; set; }

        [DataMember(Name = "flags")]
        public ICollection<string> Flags { get; set; }

        [DataMember(Name = "tiers")]
        public ICollection<Tier> Tiers { get; set; }

        [DataMember(Name = "prerequisites")]
        public ICollection<int> Prerequisites { get; set; }

        [DataMember(Name = "rewards")]
        public ICollection<Reward> Rewards { get; set; }

        [DataMember(Name = "bits")]
        public ICollection<Bit> Bits { get; set; }

        public string Endpoint { get; set; }

        public Achievement()
        {
            Endpoint = "achievements";
        }
    }
}
