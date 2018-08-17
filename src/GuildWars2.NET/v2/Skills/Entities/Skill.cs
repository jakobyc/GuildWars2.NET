using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Skills.Entities
{
    [DataContract]
    public class Skill
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "icon")]
        public string Icon { get; set; }
        [DataMember(Name = "chat_link")]
        public string ChatLink { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "weapon_type")]
        public string WeaponType { get; set; }
        [DataMember(Name = "slot")]
        public string Slot { get; set; }
        [DataMember(Name = "attunement")]
        public string Attunement { get; set; }
        [DataMember(Name = "dual_wield")]
        public string DualWield { get; set; }

        [DataMember(Name = "professions")]
        public ICollection<string> Professions { get; set; }
        [DataMember(Name = "facts")]
        public ICollection<SkillFact> Facts { get; set; }
        [DataMember(Name = "traited_facts")]
        public ICollection<TraitedSkillFact> TraitedFacts { get; set; }
        [DataMember(Name = "categories")]
        public ICollection<string> Categories { get; set; }
        [DataMember(Name = "transform_skills")]
        public ICollection<string> TransformSkills { get; set; }
        [DataMember(Name = "bundle_skills")]
        public ICollection<string> BundleSkills { get; set; }
        [DataMember(Name = "flags")]
        public ICollection<string> Flags { get; set; }

        [DataMember(Name = "cost")]
        public int Cost { get; set; }
        [DataMember(Name = "flip_skill")]
        public int FlipSkill { get; set; }
        [DataMember(Name = "initiative")]
        public int Initiative { get; set; }
        [DataMember(Name = "next_chain")]
        public int NextChain { get; set; }
        [DataMember(Name = "prev_chain")]
        public int PreviousChain { get; set; }
        [DataMember(Name = "toolbelt_skill")]
        public int ToolbeltSkill { get; set; }
    }
}
