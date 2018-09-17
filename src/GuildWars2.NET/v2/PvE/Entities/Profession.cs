using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class Profession
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("icon_big")]
        public Uri IconBig { get; set; }

        [JsonProperty("specializations")]
        public string[] SpecializationIds { get; set; }

        [JsonProperty("weapons")]
        public Weapons Weapons { get; set; }

        [JsonProperty("flags")]
        public string[] Flags { get; set; }

        [JsonProperty("skills")]
        public ProfessionSkill[] Skills { get; set; }

        [JsonProperty("training")]
        public Training[] Training { get; set; }
    }

    public class ProfessionSkill
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("slot")]
        public string Slot { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Training
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("track")]
        public Track[] Track { get; set; }
    }

    public class Track
    {
        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("skill_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SkillId { get; set; }

        [JsonProperty("trait_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TraitId { get; set; }
    }

    public class Weapons
    {
        [JsonProperty("Axe")]
        public Weapon Axe { get; set; }

        [JsonProperty("Dagger")]
        public Weapon Dagger { get; set; }

        [JsonProperty("Mace")]
        public Weapon Mace { get; set; }

        [JsonProperty("Pistol")]
        public Weapon Pistol { get; set; }

        [JsonProperty("Sword")]
        public Weapon Sword { get; set; }

        [JsonProperty("Scepter")]
        public Weapon Scepter { get; set; }

        [JsonProperty("Focus")]
        public Weapon Focus { get; set; }

        [JsonProperty("Shield")]
        public Weapon Shield { get; set; }

        [JsonProperty("Torch")]
        public Weapon Torch { get; set; }

        [JsonProperty("Warhorn")]
        public Weapon Warhorn { get; set; }

        [JsonProperty("Greatsword")]
        public Weapon Greatsword { get; set; }

        [JsonProperty("Hammer")]
        public Weapon Hammer { get; set; }

        [JsonProperty("Longbow")]
        public Weapon Longbow { get; set; }

        [JsonProperty("Rifle")]
        public Weapon Rifle { get; set; }

        [JsonProperty("Shortbow")]
        public Weapon Shortbow { get; set; }

        [JsonProperty("Staff")]
        public Weapon Staff { get; set; }

        [JsonProperty("Speargun")]
        public Weapon Speargun { get; set; }

        [JsonProperty("Spear")]
        public Weapon Spear { get; set; }

        [JsonProperty("Trident")]
        public Weapon Trident { get; set; }
    }

    public class Hammer
    {
        [JsonProperty("specialization")]
        public string Specialization { get; set; }

        [JsonProperty("flags")]
        public string[] Flags { get; set; }

        [JsonProperty("skills")]
        public HammerSkill[] Skills { get; set; }
    }

    public class HammerSkill
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("slot")]
        public string Slot { get; set; }
    }

    public class Pistol
    {
        [JsonProperty("flags")]
        public string[] Flags { get; set; }

        [JsonProperty("skills")]
        public HammerSkill[] Skills { get; set; }
    }

    public class Weapon
    {
        [JsonProperty("flags")]
        public string[] Flags { get; set; }

        [JsonProperty("specialization")]
        public string Specialization { get; set; }


        [JsonProperty("skills")]
        public WeaponSkill[] Skills { get; set; }
    }

    public class WeaponSkill
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("slot")]
        public string Slot { get; set; }

        [JsonProperty("offhand")]
        public string Offhand { get; set; }

        [JsonProperty("attunement")]
        public string Attunement { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
