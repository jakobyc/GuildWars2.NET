using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuildWars2.NET.Data;
using GuildWars2.NET.Serialization.JSON;
using GuildWars2.NET.v2.Characters.DTOs;
using GuildWars2.NET.v2.Skills.Repositories;
using GuildWars2.NET.v2.Skills.DTOs;

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
            return Retrieve<Backstory>(new Backstory(characterName), ApiKey);
        }

        public Core GetCoreInformation(string characterName)
        {
            return Retrieve<Core>(new Core(characterName), ApiKey);
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
