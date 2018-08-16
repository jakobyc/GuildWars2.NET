using GuildWars2.NET.v2.Characters.Entities;
using GuildWars2.NET.v2.Characters.Repositories;
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
        public void GetBackstory()
        {
            AssertCall<Backstory>(repository.GetBackstory(Config.Instance.Character));
        }

        [Fact]
        public void GetCoreInformation()
        {
            AssertCall<CoreInformation>(repository.GetCoreInformation(Config.Instance.Character));
        }

        [Fact]
        public void GetCraftingInformation()
        {
            AssertCall<CraftingInfo>(repository.GetCraftingInformation(Config.Instance.Character));
        }

        [Fact]
        public void GetEquipment()
        {
            AssertCall<Equipment>(repository.GetEquipment(Config.Instance.Character));
        }

        [Fact]
        public void GetHeroPoints()
        {
            AssertCall<string[]>(repository.GetHeroPoints(Config.Instance.Character));
        }

        [Fact]
        public void GetInventory()
        {
            AssertCall<Inventory>(repository.GetInventory(Config.Instance.Character));
        }

        [Fact]
        public void GetOverview()
        {
            AssertCall<CharacterOverview>(repository.GetOverview(Config.Instance.Character));
        }

        [Fact]
        public void GetRecipes()
        {
            AssertCall<CharacterRecipes>(repository.GetRecipes(Config.Instance.Character));
        }

        [Fact]
        public void GetSABInfo()
        {
            AssertCall<CharacterSAB>(repository.GetSABInfo(Config.Instance.Character));
        }

        [Fact]
        public void GetPvESkills()
        {
            AssertCall<v2.Skills.Entities.Skill[]>(repository.GetSkills(Config.Instance.Character, SkillType.PvE));
        }

        [Fact]
        public void GetPvPSkills()
        {
            AssertCall<v2.Skills.Entities.Skill[]>(repository.GetSkills(Config.Instance.Character, SkillType.PvP));
        }

        [Fact]
        public void GetWvWSkills()
        {
            AssertCall<v2.Skills.Entities.Skill[]>(repository.GetSkills(Config.Instance.Character, SkillType.WvW));
        }

        [Fact]
        public void GetSpecializations()
        {
            AssertCall<CharacterSpecializations>(repository.GetSpecializations(Config.Instance.Character));
        }

        [Fact]
        public void GetTrainingProgress()
        {
            AssertCall<Training>(repository.GetTrainingProgress(Config.Instance.Character));
        }
    }
}
