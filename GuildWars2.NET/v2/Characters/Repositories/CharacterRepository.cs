using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuildWars2.NET.Serialization.JSON;
using GuildWars2.NET.v2.Characters.DTOs;

namespace GuildWars2.NET.v2.Characters.Repositories
{
    public class CharacterRepository
    {
        private JsonDeserializer deserializer;
        private JsonRetriever retriever;

        public CharacterRepository() : this(new JsonDeserializer(), new JsonRetriever()) { }

        public CharacterRepository(JsonDeserializer deserializer, JsonRetriever retriever)
        {
            this.deserializer = deserializer;
            this.retriever = retriever;
        }

        public Backstory GetBackstory(string characterName, string accessToken)
        {
            string json = retriever.GetJson(new Backstory(characterName), accessToken);
            return deserializer.Deserialize<Backstory>(json);
        }

        public Core GetCoreInformation(string characterName, string accessToken)
        {
            string json = retriever.GetJson(new Core(characterName), accessToken);
            return deserializer.Deserialize<Core>(json);
        }

        public CraftingInfo GetCraftingInformation(string characterName, string accessToken)
        {
            string json = retriever.GetJson(new CraftingInfo(characterName), accessToken);
            return deserializer.Deserialize<CraftingInfo>(json);
        }

        public Equipment GetEquipment(string characterName, string accessToken)
        {
            string json = retriever.GetJson(new Equipment(characterName), accessToken);
            return deserializer.Deserialize<Equipment>(json);
        }

        public ICollection<string> GetHeroPoints(string characterName, string accessToken)
        {
            string json = retriever.GetJson(new HeroPoint(characterName), accessToken);
            return deserializer.Deserialize<ICollection<string>>(json);
        }

        public Inventory GetInventory(string characterName, string accessToken)
        {
            string json = retriever.GetJson(new Inventory(characterName), accessToken);
            return deserializer.Deserialize<Inventory>(json);
        }

        public Skills GetSkills(string characterName, string accessToken)
        {
            string json = retriever.GetJson(new Skills(characterName), accessToken);
            return deserializer.Deserialize<Skills>(json);
        }
    }
}
