using GuildWars2.NET.v2.Achievements.Entities;
using GuildWars2.NET.v2.Achievements.Repositories;
using GuildWars2.NET.Test.Dependencies;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class AchievementsTest : ApiTest
    {
        private AchievementRepository repository;

        public AchievementsTest(RepositoryFactory factory)
        {
            this.repository = factory.GetAchievementRepository();
        }

        [Fact]
        public void GetAchievements()
        {
            AssertCall<List<int>>(repository.GetAchievements());
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
    }
}