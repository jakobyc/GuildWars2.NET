using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.Core.v2.Characters.DTOs
{
    [DataContract]
    public class Training : IRetrievable
    {
        [DataMember(Name = "training")]
        public ICollection<SkillTree> SkillTrees { get; set; }

        public string Endpoint { get; private set; }

        public Training(string characterName)
        {
            this.Endpoint = string.Format("characters/{0}/training", characterName);
        }

        [DataContract]
        public class SkillTree
        {
            [DataMember(Name = "id")]
            public int Id { get; set; }
            [DataMember(Name = "spent")]
            public int Spent { get; set; }
            [DataMember(Name = "done")]
            public bool Done { get; set; }
        }
    }
}
