using GuildWars2.NET.v2.PvE.Entities;
using GuildWars2.NET.v2.PvE.Repositories;
using GuildWars2.NET.Test.Dependencies;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

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

        [Fact]
        public void GetAllContinents()
        {
            AssertCall<List<Continent>>(repository.GetAllContinents());
        }

        [Fact]
        public void GetContinents()
        {
            AssertCall<List<string>>(repository.GetContinents());
        }

        [Theory]
        [InlineData("1", "2")]
        public void GetContinentsById(params string[] ids)
        {
            AssertCall<List<Continent>>(repository.GetContinents(ids));
        }

        [Theory]
        [InlineData("2")]
        public void GetContinent(string id)
        {
            AssertCall<Continent>(repository.GetContinent(id));
        }

        [Fact]
        public void GetDungeons()
        {
            AssertCall<List<string>>(repository.GetDungeons());
        }

        [Theory]
        [InlineData("caudecus_manor", "twilight_arbor", "sorrows_embrace")]
        public void GetDungeonsById(params string[] ids)
        {
            AssertCall<List<Dungeon>>(repository.GetDungeons(ids));
        }

        [Theory]
        [InlineData("ascalonian_catacombs")]
        public void GetDungeon(string id)
        {
            AssertCall<Dungeon>(repository.GetDungeon(id));
        }

        [Fact]
        public void GetMaps()
        {
            AssertCall<List<string>>(repository.GetMaps());
        }

        [Theory]
        [InlineData("15", "17", "63")]
        public void GetMapsById(params string[] ids)
        {
            AssertCall<List<Map>>(repository.GetMaps(ids));
        }

        [Theory]
        [InlineData("15")]
        public void GetMap(string id)
        {
            AssertCall<Map>(repository.GetMap(id));
        }

        [Fact]
        public void GetMasteries()
        {
            AssertCall<List<string>>(repository.GetMasteries());
        }

        [Fact]
        public void GetMasteriesById()
        {
            string[] ids = repository.GetMasteries().ToArray();
            AssertCall<List<Mastery>>(repository.GetMasteries(ids));
        }

        [Theory]
        [InlineData("1")]
        public void GetMastery(string id)
        {
            AssertCall<Mastery>(repository.GetMastery(id));
        }

        [Fact]
        public void GetPets()
        {
            AssertCall<List<string>>(repository.GetPets());
        }

        [Fact]
        public void GetPetsById()
        {
            string[] ids = repository.GetPets().ToArray();
            AssertCall<List<Pet>>(repository.GetPets(ids));
        }

        [Theory]
        [InlineData("33")]
        public void GetPet(string id)
        {
            AssertCall<Pet>(repository.GetPet(id));
        }

        [Fact]
        public void GetProfessions()
        {
            AssertCall<List<string>>(repository.GetProfessions());
        }

        [Fact]
        public void GetProfessionsById()
        {
            string[] ids = repository.GetProfessions().ToArray();
            AssertCall<List<Profession>>(repository.GetProfessions(ids));
        }

        [Theory]
        [InlineData("Engineer")]
        public void GetProfession(string id)
        {
            AssertCall<Profession>(repository.GetProfession(id));
        }

        [Fact]
        public void GetRaces()
        {
            AssertCall<List<string>>(repository.GetRaces());
        }

        [Theory]
        [InlineData("Asura", "Charr", "Human")]
        public void GetRacesById(params string[] ids)
        {
            AssertCall<List<Race>>(repository.GetRaces(ids));
        }

        [Theory]
        [InlineData("Asura")]
        public void GetRace(string id)
        {
            AssertCall<Race>(repository.GetRace(id));
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
