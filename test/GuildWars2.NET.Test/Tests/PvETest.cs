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

        [Theory]
        [InlineData("1", "2", "3")]
        public void GetSpecializations(params string[] ids)
        {
            AssertCall<Specialization[]>(repository.GetSpecializations(ids));
        }

        [Theory]
        [InlineData("1")]
        public void GetSpecialization(string id)
        {
            AssertCall<Specialization>(repository.GetSpecialization(id));
        }

        [Fact]
        public void GetStories()
        {
            AssertCall<string[]>(repository.GetStories());
        }

        [Theory]
        [InlineData("1", "2", "3", "41")]
        public void GetStoriesById(params string[] ids)
        {
            AssertCall<Story[]>(repository.GetStories(ids));
        }

        [Theory]
        [InlineData("1")]
        public void GetStory(string id)
        {
            AssertCall<Story>(repository.GetStory(id));
        }

        [Fact]
        public void GetStorySeasons()
        {
            AssertCall<string[]>(repository.GetStorySeasons());
        }

        [Theory]
        [InlineData("002C2D90-69B5-41A2-A422-8DB6F2EFC53E", "A515A1D3-4BD7-4594-AE30-2C5D05FF5960")]
        public void GetStorySeasonsById(params string[] ids)
        {
            AssertCall<StorySeason[]>(repository.GetStorySeasons(ids));
        }

        [Theory]
        [InlineData("002C2D90-69B5-41A2-A422-8DB6F2EFC53E")]
        public void GetStorySeason(string id)
        {
            AssertCall<StorySeason>(repository.GetStorySeason(id));
        }

        [Fact]
        public void GetTraits()
        {
            AssertCall<string[]>(repository.GetTraits());
        }

        [Theory]
        [InlineData("214", "221", "222")]
        public void GetTraitsById(params string[] ids)
        {
            AssertCall<Trait[]>(repository.GetTraits(ids));
        }

        [Theory]
        [InlineData("214")]
        public void GetTrait(string id)
        {
            AssertCall<Trait>(repository.GetTrait(id));
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
