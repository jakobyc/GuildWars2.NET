using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class CharacterOverview
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("race")]
        public string Race { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("flags")]
        public ICollection<string> Flags { get; set; }
        [JsonProperty("profession")]
        public string Profession { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("guild")]
        public string Guild { get; set; }
        [JsonProperty("age")]
        public int Age { get; set; }
        [JsonProperty("created")]
        public string Created { get; set; }
        [JsonProperty("deaths")]
        public int Deaths { get; set; }
        [JsonProperty("crafting")]
        public ICollection<DisciplineInfo> CraftingInfo { get; set; }
        [JsonProperty("title")]
        public int Title { get; set; }
        [JsonProperty("backstory")]
        public ICollection<string> Backstory { get; set; }
        [JsonProperty("wvw_abilities")]
        public ICollection<WvWAbility> WvWAbilities { get; set; }
        [JsonProperty("specializations")]
        public Specializations SpecializationInfo { get; set; }
        [JsonProperty("skills")]
        public SkillInfo SkillInfo { get; set; }
        [JsonProperty("equipment")]
        public ICollection<EquipmentInfo> Equipment { get; set; }
        [JsonProperty("recipes")]
        public ICollection<string> Recipes { get; set; }
        [JsonProperty("equipment_pvp")]
        public EquipmentPvp Equipment_pvp { get; set; }
        // TODO: Not deserializing:
        [JsonProperty("training")]
        public ICollection<SkillTree> TrainingInfo { get; set; }
        [JsonProperty("bags")]
        public ICollection<InventoryBag> Bags { get; set; }

        public class EquipmentPvp
        {
            [JsonProperty("amulet")]
            public int Amulet { get; set; }
            [JsonProperty("rune")]
            public int Rune { get; set; }
            [JsonProperty("sigils")]
            public ICollection<int?> Sigils { get; set; }
        }

        public class WvWAbility
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("rank")]
            public int Rank { get; set; }
        }
    }
}
