using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Items.Entities
{
    public class Skin
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("flags")]
        public string[] Flags { get; set; }

        [JsonProperty("restrictions")]
        public object[] Restrictions { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }
    }

    public class Details
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("weight_class")]
        public string WeightClass { get; set; }

        [JsonProperty("dye_slots")]
        public DyeSlots DyeSlots { get; set; }
    }

    public class DyeSlots
    {
        [JsonProperty("default")]
        public Default[] Default { get; set; }

        [JsonProperty("overrides")]
        public Overrides Overrides { get; set; }
    }

    public class Default
    {
        [JsonProperty("color_id")]
        public long ColorId { get; set; }

        [JsonProperty("material")]
        public string Material { get; set; }
    }

    public class Overrides
    {
        [JsonProperty("AsuraFemale")]
        public Default[] AsuraFemale { get; set; }
        [JsonProperty("AsuraMale")]
        public Default[] AsuraMale { get; set; }
        [JsonProperty("CharrFemale")]
        public Default[] CharrFemale { get; set; }
        [JsonProperty("CharrMale")]
        public Default[] CharrMale { get; set; }
        [JsonProperty("HumanFemale")]
        public Default[] HumanFemale { get; set; }
        [JsonProperty("HumanMale")]
        public Default[] HumanMale { get; set; }
        [JsonProperty("NornFemale")]
        public Default[] NornFemale { get; set; }
        [JsonProperty("NornMale")]
        public Default[] NornMale { get; set; }
        [JsonProperty("SylvariFemale")]
        public Default[] SylvariFemale { get; set; }
        [JsonProperty("SylvariMale")]
        public Default[] SylvariMale { get; set; }

    }
}
