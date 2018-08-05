using GuildWars2.NET.Core.v2.PvE.Entities;
using GuildWars2.NET.Core.v2.PvE.Repositories;
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

        [Theory]
        [InlineData("7-54")]
        public void GetBackstoryAnswer(string id)
        {
            AssertCall<BackstoryAnswer>(repository.GetBackstoryAnswer(id));
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
    }
}
