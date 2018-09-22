using GuildWars2.NET.v2.PvE.Entities;
using GuildWars2.NET.v2.PvE.Repositories;
using GuildWars2.NET.Test.Dependencies;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using System.Threading.Tasks;

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

        #region Async
        [Fact]
        public async Task GetAllBackstoryAnswersAsync()
        {
            AssertCall<List<BackstoryAnswer>>(await repository.GetAllBackstoryAnswersAsync());
        }

        [Fact]
        public async Task GetBackstoryAnswerIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetBackstoryAnswerIdsAsync());
        }

        [Theory]
        [InlineData("7-54", "22-109")]
        public async Task GetBackstoryAnswersAsync(params string[] ids)
        {
            AssertCall<List<BackstoryAnswer>>(await repository.GetBackstoryAnswersAsync(ids));
        }

        [Theory]
        [InlineData("7-54")]
        public async Task GetBackstoryAnswerAsyncAsync(string id)
        {
            AssertCall<BackstoryAnswer>(await repository.GetBackstoryAnswerAsync(id));
        }

        [Fact]
        public async Task GetAllBackstoryQuestionsAsync()
        {
            AssertCall<List<BackstoryQuestion>>(await repository.GetAllBackstoryQuestionsAsync());
        }

        [Fact]
        public async Task GetBackstoryQuestionIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetBackstoryQuestionIdsAsync());
        }

        [Theory]
        [InlineData("7", "11")]
        public async Task GetBackstoryQuestionsAsync(params string[] ids)
        {
            AssertCall<List<BackstoryQuestion>>(await repository.GetBackstoryQuestionsAsync(ids));
        }

        [Theory]
        [InlineData("185")]
        public async Task GetBackstoryQuestionAsyncAsync(string id)
        {
            AssertCall<BackstoryQuestion>(await repository.GetBackstoryQuestionAsync(id));
        }

        [Fact]
        public async Task GetAllContinentsAsync()
        {
            AssertCall<List<Continent>>(await repository.GetAllContinentsAsync());
        }

        [Fact]
        public async Task GetContinentIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetContinentIdsAsync());
        }

        [Theory]
        [InlineData("1", "2")]
        public async Task GetContinentsAsync(params string[] ids)
        {
            AssertCall<List<Continent>>(await repository.GetContinentsAsync(ids));
        }

        [Theory]
        [InlineData("2")]
        public async Task GetContinentAsync(string id)
        {
            AssertCall<Continent>(await repository.GetContinentAsync(id));
        }

        [Fact]
        public async Task GetDungeonIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetDungeonIdsAsync());
        }

        [Theory]
        [InlineData("caudecus_manor", "twilight_arbor", "sorrows_embrace")]
        public async Task GetDungeonsAsync(params string[] ids)
        {
            AssertCall<List<Dungeon>>(await repository.GetDungeonsAsync(ids));
        }

        [Theory]
        [InlineData("ascalonian_catacombs")]
        public async Task GetDungeonAsync(string id)
        {
            AssertCall<Dungeon>(await repository.GetDungeonAsync(id));
        }

        [Fact]
        public async Task GetMapIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetMapIdsAsync());
        }

        [Theory]
        [InlineData("15", "17", "63")]
        public async Task GetMapsAsync(params string[] ids)
        {
            AssertCall<List<Map>>(await repository.GetMapsAsync(ids));
        }

        [Theory]
        [InlineData("15")]
        public async Task GetMapAsync(string id)
        {
            AssertCall<Map>(await repository.GetMapAsync(id));
        }

        [Fact]
        public async Task GetMasteryIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetMasteryIdsAsync());
        }

        [Fact]
        public async Task GetMasteriesAsync()
        {
            ICollection<string> ids = await repository.GetMasteryIdsAsync();
            AssertCall<List<Mastery>>(await repository.GetMasteriesAsync(ids.ToArray()));
        }

        [Theory]
        [InlineData("1")]
        public async Task GetMasteryAsync(string id)
        {
            AssertCall<Mastery>(await repository.GetMasteryAsync(id));
        }

        [Fact]
        public async Task GetPetIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetPetIdsAsync());
        }

        [Fact]
        public async Task GetPetsAsync()
        {
            ICollection<string> ids = await repository.GetPetIdsAsync();
            AssertCall<List<Pet>>(await repository.GetPetsAsync(ids.ToArray()));
        }

        [Theory]
        [InlineData("33")]
        public async Task GetPetAsync(string id)
        {
            AssertCall<Pet>(await repository.GetPetAsync(id));
        }

        [Fact]
        public async Task GetProfessionIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetProfessionIdsAsync());
        }

        [Fact]
        public async Task GetProfessionsAsync()
        {
            ICollection<string> ids = await repository.GetProfessionIdsAsync();
            AssertCall<List<Profession>>(await repository.GetProfessionsAsync(ids.ToArray()));
        }

        [Theory]
        [InlineData("Engineer")]
        public async Task GetProfessionAsync(string id)
        {
            AssertCall<Profession>(await repository.GetProfessionAsync(id));
        }

        [Fact]
        public async Task GetRaceIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetRaceIdsAsync());
        }

        [Theory]
        [InlineData("Asura", "Charr", "Human")]
        public async Task GetRacesAsync(params string[] ids)
        {
            AssertCall<List<Race>>(await repository.GetRacesAsync(ids));
        }

        [Theory]
        [InlineData("Asura")]
        public async Task GetRaceAsync(string id)
        {
            AssertCall<Race>(await repository.GetRaceAsync(id));
        }

        [Fact]
        public async Task GetRaidIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetRaidIdsAsync());
        }

        [Theory]
        [InlineData("forsaken_thicket", "bastion_of_the_penitent", "hall_of_chains")]
        public async Task GetRaidsAsync(params string[] ids)
        {
            AssertCall<List<Raid>>(await repository.GetRaidsAsync(ids));
        }

        [Theory]
        [InlineData("forsaken_thicket")]
        public async Task GetRaidAsync(string id)
        {
            AssertCall<Raid>(await repository.GetRaidAsync(id));
        }

        [Theory]
        [InlineData("1", "2", "3")]
        public async Task GetSpecializationsAsync(params string[] ids)
        {
            AssertCall<List<Specialization>>(await repository.GetSpecializationsAsync(ids));
        }

        [Theory]
        [InlineData("1")]
        public async Task GetSpecializationAsync(string id)
        {
            AssertCall<Specialization>(await repository.GetSpecializationAsync(id));
        }

        [Fact]
        public async Task GetStoryIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetStoryIdsAsync());
        }

        [Theory]
        [InlineData("1", "2", "3", "41")]
        public async Task GetStoriesAsync(params string[] ids)
        {
            AssertCall<List<Story>>(await repository.GetStoriesAsync(ids));
        }

        [Theory]
        [InlineData("1")]
        public async Task GetStoryAsync(string id)
        {
            AssertCall<Story>(await repository.GetStoryAsync(id));
        }

        [Fact]
        public async Task GetStorySeasonIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetStorySeasonIdsAsync());
        }

        [Theory]
        [InlineData("002C2D90-69B5-41A2-A422-8DB6F2EFC53E", "A515A1D3-4BD7-4594-AE30-2C5D05FF5960")]
        public async Task GetStorySeasonsAsync(params string[] ids)
        {
            AssertCall<List<StorySeason>>(await repository.GetStorySeasonsAsync(ids));
        }

        [Theory]
        [InlineData("002C2D90-69B5-41A2-A422-8DB6F2EFC53E")]
        public async Task GetStorySeasonAsync(string id)
        {
            AssertCall<StorySeason>(await repository.GetStorySeasonAsync(id));
        }

        [Fact]
        public async Task GetTraitIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetTraitIdsAsync());
        }

        [Theory]
        [InlineData("214", "221", "222")]
        public async Task GetTraitsAsync(params string[] ids)
        {
            AssertCall<List<Trait>>(await repository.GetTraitsAsync(ids));
        }

        [Theory]
        [InlineData("214")]
        public async Task GetTraitAsync(string id)
        {
            AssertCall<Trait>(await repository.GetTraitAsync(id));
        }

        [Fact]
        public async Task GetWorldIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetWorldIdsAsync());
        }

        [Theory]
        [InlineData("1001", "1002")]
        public async Task GetWorldsAsync(params string[] ids)
        {
            AssertCall<List<World>>(await repository.GetWorldsAsync(ids));
        }

        [Theory]
        [InlineData("1003")]
        public async Task GetWorldAsync(string id)
        {
            AssertCall<World>(await repository.GetWorldAsync(id));
        }
        #endregion
    }
}
