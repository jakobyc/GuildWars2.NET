using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuildWars2.NET.Core.Data;
using GuildWars2.NET.Core.Serialization.JSON;
using GuildWars2.NET.Core.v2.Characters.DTOs;
using GuildWars2.NET.Core.v2.Skills.Repositories;
using GuildWars2.NET.Core.v2.Skills.DTOs;

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
            return Retrieve<Backstory>(new Backstory(characterName), ApiKey);
        }

        public CoreInformation GetCoreInformation(string characterName)
        {
            return Retrieve<CoreInformation>(new CoreInformation(characterName), ApiKey);
        }

        public CraftingInfo GetCraftingInformation(string characterName)
        {
            return Retrieve<CraftingInfo>(new CraftingInfo(characterName), ApiKey);
        }

        public Equipment GetEquipment(string characterName)
        {
            return Retrieve<Equipment>(new Equipment(characterName), ApiKey);
        }

        public ICollection<string> GetHeroPoints(string characterName)
        {
            return Retrieve<ICollection<string>>(new HeroPoint(characterName), ApiKey);
        }

        public Inventory GetInventory(string characterName)
        {
            return Retrieve<Inventory>(new Inventory(characterName), ApiKey);
        }

        /// <summary>
        /// Get recipes for a character.
        /// </summary>
        /// <param name="characterName">Case-sensitive character name.</param>
        public CharacterRecipes GetRecipes(string characterName)
        {
            return Retrieve<CharacterRecipes>(new CharacterRecipes(characterName), ApiKey);
        }

        /// <summary>
        /// Get Super Adventure Box info for a character.
        /// </summary>
        /// <param name="characterName">Case-sensitive character name.</param>
        public CharacterSAB GetSABInfo(string characterName)
        {
            return Retrieve<CharacterSAB>(new CharacterSAB(characterName), ApiKey);
        }

        public ICollection<Skill> GetSkills(string characterName, SkillType type)
        {
            CharacterSkills characterSkills =  Retrieve<CharacterSkills>(new CharacterSkills(characterName), ApiKey);

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
