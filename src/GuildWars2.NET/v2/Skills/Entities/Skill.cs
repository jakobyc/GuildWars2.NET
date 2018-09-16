using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Skills.Entities
{
    public class Skill
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("chat_link")]
        public string ChatLink { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("weapon_type")]
        public string WeaponType { get; set; }
        [JsonProperty("slot")]
        public string Slot { get; set; }
        [JsonProperty("attunement")]
        public string Attunement { get; set; }
        [JsonProperty("dual_wield")]
        public string DualWield { get; set; }

        [JsonProperty("professions")]
        public ICollection<string> Professions { get; set; }
        [JsonProperty("facts")]
        public ICollection<SkillFact> Facts { get; set; }
        [JsonProperty("traited_facts")]
        public ICollection<TraitedSkillFact> TraitedFacts { get; set; }
        [JsonProperty("categories")]
        public ICollection<string> Categories { get; set; }
        [JsonProperty("transform_skills")]
        public ICollection<string> TransformSkills { get; set; }
        [JsonProperty("bundle_skills")]
        public ICollection<string> BundleSkills { get; set; }
        [JsonProperty("flags")]
        public ICollection<string> Flags { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }
        [JsonProperty("flip_skill")]
        public int FlipSkill { get; set; }
        [JsonProperty("initiative")]
        public int Initiative { get; set; }
        [JsonProperty("next_chain")]
        public int NextChain { get; set; }
        [JsonProperty("prev_chain")]
        public int PreviousChain { get; set; }
        [JsonProperty("toolbelt_skill")]
        public int ToolbeltSkill { get; set; }
    }
}
