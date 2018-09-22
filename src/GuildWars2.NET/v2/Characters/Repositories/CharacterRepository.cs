using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuildWars2.NET.Data;
using GuildWars2.NET.Serialization.JSON;
using GuildWars2.NET.v2.Characters.Entities;
using GuildWars2.NET.v2.Skills.Repositories;
using GuildWars2.NET.v2.Skills.Entities;

namespace GuildWars2.NET.v2.Characters.Repositories
{
    public enum SkillType
    {
        PvE,
        PvP,
        WvW
    }

    public class CharacterRepository : GW2Repository
    {
        public CharacterRepository(string apiKey) : base(apiKey) { }
        public CharacterRepository(string apiKey, JsonDeserializer deserializer, JsonRetriever retriever) : base(apiKey, deserializer, retriever) { }
        
        public Backstory GetBackstory(string characterName)
        {
            return Retrieve<Backstory>($"characters/{characterName}/backstory");
        }

        public CoreInformation GetCoreInformation(string characterName)
        {
            return Retrieve<CoreInformation>($"characters/{characterName}/core");
        }

        public CraftingInfo GetCraftingInformation(string characterName)
        {
            return Retrieve<CraftingInfo>($"characters/{characterName}/crafting");
        }

        public Equipment GetEquipment(string characterName)
        {
            return Retrieve<Equipment>($"characters/{characterName}/equipment");
        }

        public ICollection<string> GetHeroPoints(string characterName)
        {
            return Retrieve<ICollection<string>>($"characters/{characterName}/heropoints");
        }

        public Inventory GetInventory(string characterName)
        {
            return Retrieve<Inventory>($"characters/{characterName}/inventory");
        }

        /// <summary>
        /// Get recipes for a character.
        /// </summary>
        /// <param name="characterName">Case-sensitive character name.</param>
        public CharacterRecipes GetRecipes(string characterName)
        {
            return Retrieve<CharacterRecipes>($"characters/{characterName}/recipes");
        }

        /// <summary>
        /// Get Super Adventure Box info for a character.
        /// </summary>
        /// <param name="characterName">Case-sensitive character name.</param>
        public CharacterSAB GetSABInfo(string characterName)
        {
            return Retrieve<CharacterSAB>($"characters/{characterName}/sab");
        }

        public ICollection<Skill> GetSkills(string characterName, SkillType type)
        {
            CharacterSkills characterSkills =  Retrieve<CharacterSkills>($"characters/{characterName}/skills");

            ICollection<Skill> skills = new List<Skill>();
            SkillRepository repository = new SkillRepository();
            switch (type)
            {
                case (SkillType.PvE):
                    skills = repository.GetSkills(GetSkillIds(characterSkills.SkillsInformation.PvE));
                    break;

                case (SkillType.PvP):
                    skills = repository.GetSkills(GetSkillIds(characterSkills.SkillsInformation.PvP));
                    break;

                case (SkillType.WvW):
                    skills = repository.GetSkills(GetSkillIds(characterSkills.SkillsInformation.WvW));
                    break;
            }

            return skills;
        }

        public CharacterSpecializations GetSpecializations(string characterName)
        {
            return Retrieve<CharacterSpecializations>($"characters/{characterName}/specializations");
        }

        /// <summary>
        /// Get training progress for each skill tree for a character.
        /// </summary>
        /// <param name="characterName">Case-sensitive character name.</param>
        public Training GetTrainingProgress(string characterName)
        {
            return Retrieve<Training>($"characters/{characterName}/training");
        }

        /// <summary>
        /// Get an overview for a character.
        /// </summary>
        /// <param name="characterName">Case-sensitive character name.</param>
        public CharacterOverview GetOverview(string characterName)
        {
            return Retrieve<CharacterOverview>($"characters/{characterName}");
        }

        private string[] GetSkillIds(CharacterSkill skill)
        {
            ICollection<string> ids = new List<string>()
                    {
                        skill.EliteId.ToString(),
                        skill.HealId.ToString()
                    };

            foreach (string skillId in skill.UtilitiesIDs)
            {
                ids.Add(skillId.ToString());
            }

            return ids.ToArray<string>();
        }
    }
}
