using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.Core.v2.Characters.DTOs
{
    [DataContract]
    public class CharacterOverview : IRetrievable
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "race")]
        public string Race { get; set; }
        [DataMember(Name = "gender")]
        public string Gender { get; set; }
        [DataMember(Name = "flags")]
        public ICollection<string> Flags { get; set; }
        [DataMember(Name = "profession")]
        public string Profession { get; set; }
        [DataMember(Name = "level")]
        public int Level { get; set; }
        [DataMember(Name = "guild")]
        public string Guild { get; set; }
        [DataMember(Name = "age")]
        public int Age { get; set; }
        [DataMember(Name = "created")]
        public string Created { get; set; }
        [DataMember(Name = "deaths")]
        public int Deaths { get; set; }
        [DataMember(Name = "crafting")]
        public ICollection<DisciplineInfo> CraftingInfo { get; set; }
        [DataMember(Name = "title")]
        public int Title { get; set; }
        [DataMember(Name = "backstory")]
        public ICollection<string> Backstory { get; set; }
        [DataMember(Name = "wvw_abilities")]
        public ICollection<WvWAbility> WvWAbilities { get; set; }
        [DataMember(Name = "specializations")]
        public Specializations SpecializationInfo { get; set; }
        [DataMember(Name = "skills")]
        public SkillInfo SkillInfo { get; set; }
        [DataMember(Name = "equipment")]
        public ICollection<EquipmentInfo> Equipment { get; set; }
        [DataMember(Name = "recipes")]
        public ICollection<int> Recipes { get; set; }
        [DataMember(Name = "equipment_pvp")]
        public EquipmentPvp Equipment_pvp { get; set; }
        // TODO: Not deserializing:
        [DataMember(Name = "training")]
        public ICollection<SkillTree> TrainingInfo { get; set; }
        [DataMember(Name = "bags")]
        public ICollection<InventoryBag> Bags { get; set; }

        public string Endpoint { get; private set; }

        public CharacterOverview(string characterName)
        {
            this.Endpoint = $"characters/{characterName}";
        }

        [DataContract]
        public class EquipmentPvp
        {
            [DataMember(Name = "amulet")]
            public int Amulet { get; set; }
            [DataMember(Name = "rune")]
            public int Rune { get; set; }
            [DataMember(Name = "sigils")]
            public ICollection<int?> Sigils { get; set; }
        }

        [DataContract]
        public class WvWAbility
        {
            [DataMember(Name = "id")]
            public int Id { get; set; }
            [DataMember(Name = "rank")]
            public int Rank { get; set; }
        }
    }
}
