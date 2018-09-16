using GuildWars2.NET.v2.PvE.Entities;
using GuildWars2.NET.v2.PvE.Repositories;
using GuildWars2.NET.Test.Dependencies;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class PvETest : ApiTest
    {
        private PvERepository repository;

        public PvETest(RepositoryFactory factory)
        {
            this.repository = factory.GetPvERepository();
        }

        [Fact]
        public void GetBackstoryAnswers()
        {
            AssertCall<string[]>(repository.GetBackstoryAnswers());
        }

        [Theory]
        [InlineData("7-54", "22-109")]
        public void GetBackstoryAnswersById(params string[] ids)
        {
            AssertCall<BackstoryAnswer[]>(repository.GetBackstoryAnswers(ids));
        }

        [Theory]
        [InlineData("7-54")]
        public void GetBackstoryAnswer(string id)
        {
            AssertCall<BackstoryAnswer>(repository.GetBackstoryAnswer(id));
        }

        [Fact]
        public void GetWorlds()
        {
            AssertCall<int[]>(repository.GetWorlds());
        }

        [Theory]
        [InlineData("1001", "1002")]
        public void GetWorldsById(params string[] ids)
        {
            AssertCall<World[]>(repository.GetWorlds(ids));
        }

        [Theory]
        [InlineData("1003")]
        public void GetWorld(string id)
        {
            AssertCall<World>(repository.GetWorld(id));
        }
    }
}
