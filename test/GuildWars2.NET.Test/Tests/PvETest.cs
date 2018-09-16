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
            AssertCall<List<string>>(repository.GetBackstoryAnswers());
        }

        [Theory]
        [InlineData("7-54", "22-109")]
        public void GetBackstoryAnswersById(params string[] ids)
        {
            AssertCall<List<BackstoryAnswer>>(repository.GetBackstoryAnswers(ids));
        }

        [Theory]
        [InlineData("7-54")]
        public void GetBackstoryAnswer(string id)
        {
            AssertCall<BackstoryAnswer>(repository.GetBackstoryAnswer(id));
        }

        [Fact]
        public void GetRaids()
        {
            AssertCall<List<string>>(repository.GetRaids());
        }

        [Theory]
        [InlineData("forsaken_thicket", "bastion_of_the_penitent", "hall_of_chains")]
        public void GetRaidsById(params string[] ids)
        {
            AssertCall<List<Raid>>(repository.GetRaids(ids));
        }

        [Theory]
        [InlineData("forsaken_thicket")]
        public void GetRaid(string id)
        {
            AssertCall<Raid>(repository.GetRaid(id));
        }

        [Theory]
        [InlineData("1", "2", "3")]
        public void GetSpecializations(params string[] ids)
        {
            AssertCall<List<Specialization>>(repository.GetSpecializations(ids));
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
            AssertCall<List<string>>(repository.GetStories());
        }

        [Theory]
        [InlineData("1", "2", "3", "41")]
        public void GetStoriesById(params string[] ids)
        {
            AssertCall<List<Story>>(repository.GetStories(ids));
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
            AssertCall<List<string>>(repository.GetStorySeasons());
        }

        [Theory]
        [InlineData("002C2D90-69B5-41A2-A422-8DB6F2EFC53E", "A515A1D3-4BD7-4594-AE30-2C5D05FF5960")]
        public void GetStorySeasonsById(params string[] ids)
        {
            AssertCall<List<StorySeason>>(repository.GetStorySeasons(ids));
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
            AssertCall<List<string>>(repository.GetTraits());
        }

        [Theory]
        [InlineData("214", "221", "222")]
        public void GetTraitsById(params string[] ids)
        {
            AssertCall<List<Trait>>(repository.GetTraits(ids));
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
            AssertCall<List<int>>(repository.GetWorlds());
        }

        [Theory]
        [InlineData("1001", "1002")]
        public void GetWorldsById(params string[] ids)
        {
            AssertCall<List<World>>(repository.GetWorlds(ids));
        }

        [Theory]
        [InlineData("1003")]
        public void GetWorld(string id)
        {
            AssertCall<World>(repository.GetWorld(id));
        }
    }
}
