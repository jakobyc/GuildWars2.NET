using GuildWars2.NET.Core.v2.Characters.Entities;
using GuildWars2.NET.Core.v2.Characters.Repositories;
using GuildWars2.NET.Test.Dependencies;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class CharacterTest : ApiTest
    {
        private CharacterRepository repository;

        public CharacterTest(RepositoryFactory factory)
        {
            this.repository = factory.GetCharacterRepository();
        }

        [Fact]
        public void Get()
        {
            Assert.NotNull(repository);

            AssertCall<Backstory>(repository.GetBackstory(Config.Instance.Character));
            AssertCall<CoreInformation>(repository.GetCoreInformation(Config.Instance.Character));
            AssertCall<CraftingInfo>(repository.GetCraftingInformation(Config.Instance.Character));
            AssertCall<Equipment>(repository.GetEquipment(Config.Instance.Character));
            AssertCall<string[]>(repository.GetHeroPoints(Config.Instance.Character));
            AssertCall<Inventory>(repository.GetInventory(Config.Instance.Character));
            AssertCall<CharacterOverview>(repository.GetOverview(Config.Instance.Character));
            AssertCall<CharacterRecipes>(repository.GetRecipes(Config.Instance.Character));
            AssertCall<CharacterSAB>(repository.GetSABInfo(Config.Instance.Character));
            AssertCall<Core.v2.Skills.Entities.Skill[]>(repository.GetSkills(Config.Instance.Character, SkillType.PvE));
            AssertCall<Core.v2.Skills.Entities.Skill[]>(repository.GetSkills(Config.Instance.Character, SkillType.PvP));
            AssertCall<Core.v2.Skills.Entities.Skill[]>(repository.GetSkills(Config.Instance.Character, SkillType.WvW));
            AssertCall<CharacterSpecializations>(repository.GetSpecializations(Config.Instance.Character));
            AssertCall<Training>(repository.GetTrainingProgress(Config.Instance.Character));
        }
    }
}
