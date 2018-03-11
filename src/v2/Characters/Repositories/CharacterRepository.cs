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
        public CharacterRepository() : base() { }
        public CharacterRepository(JsonDeserializer deserializer, JsonRetriever retriever) : base(deserializer, retriever) { }

        public Backstory GetBackstory(string characterName, string accessToken)
        {
            return Retrieve<Backstory>(new Backstory(characterName), accessToken);
        }

        public Core GetCoreInformation(string characterName, string accessToken)
        {
            return Retrieve<Core>(new Core(characterName), accessToken);
        }

        public CraftingInfo GetCraftingInformation(string characterName, string accessToken)
        {
            return Retrieve<CraftingInfo>(new CraftingInfo(characterName), accessToken);
        }

        public Equipment GetEquipment(string characterName, string accessToken)
        {
            return Retrieve<Equipment>(new Equipment(characterName), accessToken);
        }

        public ICollection<string> GetHeroPoints(string characterName, string accessToken)
        {
            return Retrieve<ICollection<string>>(new HeroPoint(characterName), accessToken);
        }

        public Inventory GetInventory(string characterName, string accessToken)
        {
            return Retrieve<Inventory>(new Inventory(characterName), accessToken);
        }

        public ICollection<Skill> GetSkills(string characterName, SkillType type, string accessToken)
        {
            CharacterSkills characterSkills =  Retrieve<CharacterSkills>(new CharacterSkills(characterName), accessToken);

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
