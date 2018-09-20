using GuildWars2.NET.Test.Dependencies;
using GuildWars2.NET.v2.Guilds.Entities;
using GuildWars2.NET.v2.Guilds.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class GuildTest : ApiTest
    {
        private GuildRepository repository;

        public GuildTest(RepositoryFactory factory)
        {
            this.repository = factory.GetGuildRepository();
        }

        [Fact]
        public void GetBackgroundEmblems()
        {
            AssertCall<List<string>>(repository.GetBackgroundEmblems());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public void GetBackgroundEmblemsById(params string[] ids)
        {
            AssertCall<List<Emblem>>(repository.GetBackgroundEmblems(ids));
        }

        [Theory]
        [InlineData("21")]
        public void GetBackgroundEmblem(string id)
        {
            AssertCall<Emblem>(repository.GetBackgroundEmblem(id));
        }

        [Fact]
        public void GetForegroundEmblems()
        {
            AssertCall<List<string>>(repository.GetForegroundEmblems());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public void GetForegroundEmblemsById(params string[] ids)
        {
            AssertCall<List<Emblem>>(repository.GetForegroundEmblems(ids));
        }

        [Theory]
        [InlineData("46")]
        public void GetForegroundEmblem(string id)
        {
            AssertCall<Emblem>(repository.GetForegroundEmblem(id));
        }

        [Theory]
        [InlineData("116E0C0E-0035-44A9-BB22-4AE3E23127E5")]
        public void GetGuild(string id)
        {
            AssertCall<Guild>(repository.GetGuild(id));
        }
    }
}
