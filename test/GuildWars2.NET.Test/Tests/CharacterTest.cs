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
            AssertCall<Backstory>(repository.GetBackstory(Config.GetCharacter()));
        }

        [Fact]
        public void GetCoreInformation()
        {
            AssertCall<CoreInformation>(repository.GetCoreInformation(Config.GetCharacter()));
        }

        [Fact]
        public void GetCraftingInformation()
        {
            AssertCall<CraftingInfo>(repository.GetCraftingInformation(Config.GetCharacter()));
        }

        [Fact]
        public void GetEquipment()
        {
            AssertCall<Equipment>(repository.GetEquipment(Config.GetCharacter()));
        }

        [Fact]
        public void GetHeroPoints()
        {
            AssertCall<string[]>(repository.GetHeroPoints(Config.GetCharacter()));
        }

        [Fact]
        public void GetInventory()
        {
            AssertCall<Inventory>(repository.GetInventory(Config.GetCharacter()));
        }

        [Fact]
        public void GetOverview()
        {
            AssertCall<CharacterOverview>(repository.GetOverview(Config.GetCharacter()));
        }

        [Fact]
        public void GetRecipes()
        {
            AssertCall<CharacterRecipes>(repository.GetRecipes(Config.GetCharacter()));
        }

        [Fact]
        public void GetSABInfo()
        {
            AssertCall<CharacterSAB>(repository.GetSABInfo(Config.GetCharacter()));
        }

        [Fact]
        public void GetPvESkills()
        {
            AssertCall<v2.Skills.Entities.Skill[]>(repository.GetSkills(Config.GetCharacter(), SkillType.PvE));
        }

        [Fact]
        public void GetPvPSkills()
        {
            AssertCall<v2.Skills.Entities.Skill[]>(repository.GetSkills(Config.GetCharacter(), SkillType.PvP));
        }

        [Fact]
        public void GetWvWSkills()
        {
            AssertCall<v2.Skills.Entities.Skill[]>(repository.GetSkills(Config.GetCharacter(), SkillType.WvW));
        }

        [Fact]
        public void GetSpecializations()
        {
            AssertCall<CharacterSpecializations>(repository.GetSpecializations(Config.GetCharacter()));
        }

        [Fact]
        public void GetTrainingProgress()
        {
            AssertCall<Training>(repository.GetTrainingProgress(Config.GetCharacter()));
        }
    }
}
