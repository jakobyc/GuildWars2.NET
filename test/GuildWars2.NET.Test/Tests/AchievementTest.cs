using GuildWars2.NET.v2.Achievements.Entities;
using GuildWars2.NET.v2.Achievements.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Threading.Tasks;

namespace GuildWars2.NET.Test.Tests
{
    public class AchievementsTest : ApiTest
    {
        private readonly AchievementRepository repository;

        public AchievementsTest()
        {
            this.repository = Client.Achievements;
        }

        [Fact]
        public void GetAchievementIds()
        {
            AssertIds<List<string>>(repository.GetAchievements());
        }

        [Fact]
        public void GetCategories()
        {
            AssertCall<List<Category>>(repository.GetCategories());
        }

        [Fact]
        public void GetCategory()
        {
            AssertCall<Category>(repository.GetCategory("1"));
        }

        [Fact]
        public void GetDailies()
        {
            AssertCall<Dailies>(repository.GetDailies());
        }

        [Fact]
        public void GetTomorrowsDailies()
        {
            AssertCall<Dailies>(repository.GetTomorrowsDailies());
        }

        #region Async
        [Fact]
        public async Task GetAchievementIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetAchievementsAsync());
        }

        [Fact]
        public async Task GetCategoriesAsync()
        {
            AssertCall<List<Category>>(await repository.GetCategoriesAsync());
        }

        [Fact]
        public async Task GetCategoryAsync()
        {
            AssertCall<Category>(await repository.GetCategoryAsync("1"));
        }

        [Fact]
        public async Task GetDailiesAsync()
        {
            AssertCall<Dailies>(await repository.GetDailiesAsync());
        }

        [Fact]
        public async Task GetTomorrowsDailiesAsync()
        {
            AssertCall<Dailies>(await repository.GetTomorrowsDailiesAsync());
        }
        #endregion
    }
}