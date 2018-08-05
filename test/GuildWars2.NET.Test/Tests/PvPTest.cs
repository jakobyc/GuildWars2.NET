using GuildWars2.NET.Core.v2.PvP.Repositories;
using GuildWars2.NET.Test.Dependencies;
using GuildWars2.NET.v2.PvP.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class PvPTest : ApiTest
    {
        private PvPRepository repository;

        public PvPTest(RepositoryFactory factory)
        {
            this.repository = factory.GetPvPRepository();
        }

        [Fact]
        public void GetWvWAbilities()
        {
            AssertCall<int[]>(repository.GetWvWAbilities());
        }

        [Theory]
        [InlineData("4", "24")]
        public void GetWvWAbilitiesByIds(params string[] ids)
        {
            AssertCall<WvWAbility[]>(repository.GetWvWAbilities(ids));
        }
    }
}
