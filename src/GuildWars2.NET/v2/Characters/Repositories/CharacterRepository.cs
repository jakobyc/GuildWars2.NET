using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuildWars2.NET.Core.Data;
using GuildWars2.NET.Core.Serialization.JSON;
using GuildWars2.NET.Core.v2.Characters.Entities;
using GuildWars2.NET.Core.v2.Skills.Repositories;
using GuildWars2.NET.Core.v2.Skills.Entities;

namespace GuildWars2.NET.Core.v2.Characters.Repositories
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
            return Retrieve<Backstory>(CreateEndpoint($"characters/{characterName}/backstory", ApiKey));
        }

        public CoreInformation GetCoreInformation(string characterName)
        {
            return Retrieve<CoreInformation>(CreateEndpoint($"characters/{characterName}/core", ApiKey));
        }

        public CraftingInfo GetCraftingInformation(string characterName)
        {
            return Retrieve<CraftingInfo>(CreateEndpoint($"characters/{characterName}/crafting", ApiKey));
        }

        public Equipment GetEquipment(string characterName)
        {
            return Retrieve<Equipment>(CreateEndpoint($"characters/{characterName}/equipment", ApiKey));
        }

        public ICollection<string> GetHeroPoints(string characterName)
        {
            return Retrieve<ICollection<string>>(CreateEndpoint($"characters/{characterName}/heropoints", ApiKey));
        }

        public Inventory GetInventory(string characterName)
        {
            return Retrieve<Inventory>(CreateEndpoint($"characters/{characterName}/inventory", ApiKey));
        }

        /// <summary>
        /// Get recipes for a character.
        /// </summary>
        /// <param name="characterName">Case-sensitive character name.</param>
        public CharacterRecipes GetRecipes(string characterName)
        {
            return Retrieve<CharacterRecipes>(CreateEndpoint($"characters/{characterName}/recipes", ApiKey));
        }

        /// <summary>
        /// Get Super Adventure Box info for a character.
        /// </summary>
        /// <param name="characterName">Case-sensitive character name.</param>
        public CharacterSAB GetSABInfo(string characterName)
        {
            return Retrieve<CharacterSAB>(CreateEndpoint($"characters/{characterName}/sab", ApiKey));
        }

        public ICollection<Skill> GetSkills(string characterName, SkillType type)
        {
            CharacterSkills characterSkills =  Retrieve<CharacterSkills>(CreateEndpoint($"characters/{characterName}/skills", ApiKey));

            ICollection<Skill> skills = new List<Skill>();
            SkillRepository repository = new SkillRepository(ApiKey);
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
            return Retrieve<CharacterSpecializations>(CreateEndpoint($"characters/{characterName}/specializations", ApiKey));
        }

        /// <summary>
        /// Get training progress for each skill tree for a character.
        /// </summary>
        /// <param name="characterName">Case-sensitive character name.</param>
        public Training GetTrainingProgress(string characterName)
        {
            return Retrieve<Training>(CreateEndpoint($"characters/{characterName}/training", ApiKey));
        }

        /// <summary>
        /// Get an overview for a character.
        /// </summary>
        /// <param name="characterName">Case-sensitive character name.</param>
        public CharacterOverview GetOverview(string characterName)
        {
            return Retrieve<CharacterOverview>(CreateEndpoint($"characters/{characterName}", ApiKey));
        }

        private string[] GetSkillIds(CharacterSkill skill)
        {
            ICollection<string> ids = new List<string>()
                    {
                        skill.EliteId.ToString(),
                        skill.HealId.ToString()
                    };

            foreach (int skillId in skill.UtilitiesIDs)
            {
                ids.Add(skillId.ToString());
            }

            return ids.ToArray<string>();
        }
    }
}
