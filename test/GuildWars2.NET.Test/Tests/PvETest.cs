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
        public void GetAllBackstoryAnswers()
        {
            AssertCall<List<BackstoryAnswer>>(repository.GetAllBackstoryAnswers());
        }

        [Fact]
        public void GetBackstoryAnswerIds()
        {
            AssertIds<List<string>>(repository.GetBackstoryAnswerIds());
        }

        [Theory]
        [InlineData("7-54", "22-109")]
        public void GetBackstoryAnswers(params string[] ids)
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
        public void GetAllBackstoryQuestions()
        {
            AssertCall<List<BackstoryQuestion>>(repository.GetAllBackstoryQuestions());
        }

        [Fact]
        public void GetBackstoryQuestionIds()
        {
            AssertIds<List<string>>(repository.GetBackstoryQuestionIds());
        }

        [Theory]
        [InlineData("7", "11")]
        public void GetBackstoryQuestions(params string[] ids)
        {
            AssertCall<List<BackstoryQuestion>>(repository.GetBackstoryQuestions(ids));
        }

        [Theory]
        [InlineData("185")]
        public void GetBackstoryQuestion(string id)
        {
            AssertCall<BackstoryQuestion>(repository.GetBackstoryQuestion(id));
        }

        [Fact]
        public void GetAllContinents()
        {
            AssertCall<List<Continent>>(repository.GetAllContinents());
        }

        [Fact]
        public void GetContinentIds()
        {
            AssertIds<List<string>>(repository.GetContinentIds());
        }

        [Theory]
        [InlineData("1", "2")]
        public void GetContinents(params string[] ids)
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
        public void GetDungeonIds()
        {
            AssertIds<List<string>>(repository.GetDungeonIds());
        }

        [Theory]
        [InlineData("caudecus_manor", "twilight_arbor", "sorrows_embrace")]
        public void GetDungeons(params string[] ids)
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
        public void GetMapIds()
        {
            AssertIds<List<string>>(repository.GetMapIds());
        }

        [Theory]
        [InlineData("15", "17", "63")]
        public void GetMaps(params string[] ids)
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
        public void GetMasteryIds()
        {
            AssertIds<List<string>>(repository.GetMasteryIds());
        }

        [Fact]
        public void GetMasteries()
        {
            string[] ids = repository.GetMasteryIds().ToArray();
            AssertCall<List<Mastery>>(repository.GetMasteries(ids));
        }

        [Theory]
        [InlineData("1")]
        public void GetMastery(string id)
        {
            AssertCall<Mastery>(repository.GetMastery(id));
        }

        [Fact]
        public void GetPetIds()
        {
            AssertIds<List<string>>(repository.GetPetIds());
        }

        [Fact]
        public void GetPets()
        {
            string[] ids = repository.GetPetIds().ToArray();
            AssertCall<List<Pet>>(repository.GetPets(ids));
        }

        [Theory]
        [InlineData("33")]
        public void GetPet(string id)
        {
            AssertCall<Pet>(repository.GetPet(id));
        }

        [Fact]
        public void GetProfessionIds()
        {
            AssertIds<List<string>>(repository.GetProfessionIds());
        }

        [Fact]
        public void GetProfessions()
        {
            string[] ids = repository.GetProfessionIds().ToArray();
            AssertCall<List<Profession>>(repository.GetProfessions(ids));
        }

        [Theory]
        [InlineData("Engineer")]
        public void GetProfession(string id)
        {
            AssertCall<Profession>(repository.GetProfession(id));
        }

        [Fact]
        public void GetRaceIds()
        {
            AssertIds<List<string>>(repository.GetRaceIds());
        }

        [Theory]
        [InlineData("Asura", "Charr", "Human")]
        public void GetRaces(params string[] ids)
        {
            AssertCall<List<Race>>(repository.GetRaces(ids));
        }

        [Theory]
        [InlineData("Asura")]
        public void GetRace(string id)
        {
            AssertCall<Race>(repository.GetRace(id));
        }

        [Fact]
        public void GetRaidIds()
        {
            AssertIds<List<string>>(repository.GetRaidIds());
        }

        [Theory]
        [InlineData("forsaken_thicket", "bastion_of_the_penitent", "hall_of_chains")]
        public void GetRaids(params string[] ids)
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
        public void GetStoryIds()
        {
            AssertIds<List<string>>(repository.GetStoryIds());
        }

        [Theory]
        [InlineData("1", "2", "3", "41")]
        public void GetStories(params string[] ids)
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
        public void GetStorySeasonIds()
        {
            AssertIds<List<string>>(repository.GetStorySeasonIds());
        }

        [Theory]
        [InlineData("002C2D90-69B5-41A2-A422-8DB6F2EFC53E", "A515A1D3-4BD7-4594-AE30-2C5D05FF5960")]
        public void GetStorySeasons(params string[] ids)
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
        public void GetTraitIds()
        {
            AssertIds<List<string>>(repository.GetTraitIds());
        }

        [Theory]
        [InlineData("214", "221", "222")]
        public void GetTraits(params string[] ids)
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
        public void GetWorldIds()
        {
            AssertIds<List<string>>(repository.GetWorldIds());
        }

        [Theory]
        [InlineData("1001", "1002")]
        public void GetWorlds(params string[] ids)
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
