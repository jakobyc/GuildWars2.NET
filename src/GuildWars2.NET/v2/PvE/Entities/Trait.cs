using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class Trait
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("tier")]
        public int Tier { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("slot")]
        public string Slot { get; set; }
        [JsonProperty("specialization")]
        public int Specialization { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("facts")]
        public List<Fact> Facts { get; set; }
        [JsonProperty("traited_facts")]
        public List<TraitedFact> TraitedFacts { get; set; }


        public class Fact
        {
            [JsonProperty("text")]
            public string Text { get; set; }
            [JsonProperty("type")]
            public string Type { get; set; }
            [JsonProperty("icon")]
            public string Icon { get; set; }
            [JsonProperty("percent")]
            public int Percent { get; set; }
            [JsonProperty("value")]
            public int? Value { get; set; }
            [JsonProperty("target")]
            public string Target { get; set; }
        }

        public class TraitedFact
        {
            [JsonProperty("text")]
            public string Text { get; set; }
            [JsonProperty("type")]
            public string Type { get; set; }
            [JsonProperty("icon")]
            public string Icon { get; set; }
            [JsonProperty("value")]
            public int Value { get; set; }
            [JsonProperty("requires_trait")]
            public int RequiresTrait { get; set; }
            [JsonProperty("target")]
            public string Target { get; set; }
        }
    }
}
