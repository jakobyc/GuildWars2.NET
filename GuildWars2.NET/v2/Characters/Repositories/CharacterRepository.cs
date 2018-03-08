using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuildWars2.NET.Data;
using GuildWars2.NET.Serialization.JSON;
using GuildWars2.NET.v2.Characters.DTOs;

namespace GuildWars2.NET.v2.Characters.Repositories
{
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

        public v2.Characters.DTOs.Skills GetSkills(string characterName, string accessToken)
        {
            return Retrieve<v2.Characters.DTOs.Skills>(new v2.Characters.DTOs.Skills(characterName), accessToken);
        }
    }
}
