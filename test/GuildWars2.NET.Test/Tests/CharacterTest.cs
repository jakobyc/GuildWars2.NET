using GuildWars2.NET.v2.Characters.Entities;
using GuildWars2.NET.v2.Characters.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Threading.Tasks;

namespace GuildWars2.NET.Test.Tests
{
    public class CharacterTest : ApiTest
    {
        private readonly ICharacterRepository repository;

        public CharacterTest()
        {
            this.repository = Client.Characters;
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
            AssertCall<List<string>>(repository.GetHeroPoints(Config.GetCharacter()));
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
            AssertCall<List<v2.Skills.Entities.Skill>>(repository.GetSkills(Config.GetCharacter(), SkillType.PvE));
        }

        [Fact]
        public void GetPvPSkills()
        {
            AssertCall<List<v2.Skills.Entities.Skill>>(repository.GetSkills(Config.GetCharacter(), SkillType.PvP));
        }

        [Fact]
        public void GetWvWSkills()
        {
            AssertCall<List<v2.Skills.Entities.Skill>>(repository.GetSkills(Config.GetCharacter(), SkillType.WvW));
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

        #region Async
        [Fact]
        public async Task GetBackstoryAsync()
        {
            AssertCall<Backstory>(await repository.GetBackstoryAsync(Config.GetCharacter()));
        }

        [Fact]
        public async Task GetCoreInformationAsync()
        {
            AssertCall<CoreInformation>(await repository.GetCoreInformationAsync(Config.GetCharacter()));
        }

        [Fact]
        public async Task GetCraftingInformationAsync()
        {
            AssertCall<CraftingInfo>(await repository.GetCraftingInformationAsync(Config.GetCharacter()));
        }

        [Fact]
        public async Task GetEquipmentAsync()
        {
            AssertCall<Equipment>(await repository.GetEquipmentAsync(Config.GetCharacter()));
        }

        [Fact]
        public async Task GetHeroPointsAsync()
        {
            AssertCall<List<string>>(await repository.GetHeroPointsAsync(Config.GetCharacter()));
        }

        [Fact]
        public async Task GetInventoryAsync()
        {
            AssertCall<Inventory>(await repository.GetInventoryAsync(Config.GetCharacter()));
        }

        [Fact]
        public async Task GetOverviewAsync()
        {
            AssertCall<CharacterOverview>(await repository.GetOverviewAsync(Config.GetCharacter()));
        }

        [Fact]
        public async Task GetRecipesAsync()
        {
            AssertCall<CharacterRecipes>(await repository.GetRecipesAsync(Config.GetCharacter()));
        }

        [Fact]
        public async Task GetSABInfoAsync()
        {
            AssertCall<CharacterSAB>(await repository.GetSABInfoAsync(Config.GetCharacter()));
        }

        [Fact]
        public async Task GetPvESkillsAsync()
        {
            AssertCall<List<v2.Skills.Entities.Skill>>(await repository.GetSkillsAsync(Config.GetCharacter(), SkillType.PvE));
        }

        [Fact]
        public async Task GetPvPSkillsAsync()
        {
            AssertCall<List<v2.Skills.Entities.Skill>>(await repository.GetSkillsAsync(Config.GetCharacter(), SkillType.PvP));
        }

        [Fact]
        public async Task GetWvWSkillsAsync()
        {
            AssertCall<List<v2.Skills.Entities.Skill>>(await repository.GetSkillsAsync(Config.GetCharacter(), SkillType.WvW));
        }

        [Fact]
        public async Task GetSpecializationsAsync()
        {
            AssertCall<CharacterSpecializations>(await repository.GetSpecializationsAsync(Config.GetCharacter()));
        }

        [Fact]
        public async Task GetTrainingProgressAsync()
        {
            AssertCall<Training>(await repository.GetTrainingProgressAsync(Config.GetCharacter()));
        }
        #endregion
    }
}
