using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    [DataContract]
    public class Trait
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "tier")]
        public int Tier { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "slot")]
        public string Slot { get; set; }
        [DataMember(Name = "specialization")]
        public int Specialization { get; set; }
        [DataMember(Name = "icon")]
        public string Icon { get; set; }
        [DataMember(Name = "facts")]
        public List<Fact> Facts { get; set; }
        [DataMember(Name = "traited_facts")]
        public List<TraitedFact> TraitedFacts { get; set; }


        [DataContract]
        public class Fact
        {
            [DataMember(Name = "text")]
            public string Text { get; set; }
            [DataMember(Name = "type")]
            public string Type { get; set; }
            [DataMember(Name = "icon")]
            public string Icon { get; set; }
            [DataMember(Name = "percent")]
            public int Percent { get; set; }
            [DataMember(Name = "value")]
            public int? Value { get; set; }
            [DataMember(Name = "target")]
            public string Target { get; set; }
        }

        [DataContract]
        public class TraitedFact
        {
            [DataMember(Name = "text")]
            public string Text { get; set; }
            [DataMember(Name = "type")]
            public string Type { get; set; }
            [DataMember(Name = "icon")]
            public string Icon { get; set; }
            [DataMember(Name = "value")]
            public int Value { get; set; }
            [DataMember(Name = "requires_trait")]
            public int RequiresTrait { get; set; }
            [DataMember(Name = "target")]
            public string Target { get; set; }
        }
    }
}
