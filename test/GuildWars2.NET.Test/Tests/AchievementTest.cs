using GuildWars2.NET.Core.v2.Achievements.DTOs;
using GuildWars2.NET.Core.v2.Achievements.Repositories;
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
        public void Get()
        {
            Assert.NotNull(repository);

            AssertCall<int[]>(repository.GetAchievements());
            AssertCall<Category[]>(repository.GetCategories());
            AssertCall<Category>(repository.GetCategory("1"));
            AssertCall<Dailies>(repository.GetDailies());
            AssertCall<Dailies>(repository.GetTomorrowsDailies());
        }
    }
}