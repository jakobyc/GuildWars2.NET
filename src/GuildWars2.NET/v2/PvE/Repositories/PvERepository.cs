using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.v2.PvE.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.PvE.Repositories
{
    public class PvERepository : GW2Repository
    {
        public PvERepository() : base() { }

        public ICollection<BackstoryAnswer> GetAllBackstoryAnswers()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("backstory/answers")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<BackstoryAnswer>>(builder);
        }

        public ICollection<string> GetBackstoryAnswerIds()
        {
            return Retrieve<ICollection<string>>("backstory/answers");
        }

        public ICollection<BackstoryAnswer> GetBackstoryAnswers(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("backstory/answers")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<BackstoryAnswer>>(builder);
        }

        public BackstoryAnswer GetBackstoryAnswer(string id)
        {
            return Retrieve<BackstoryAnswer>($"backstory/answers/{id}");
        }

        public ICollection<BackstoryQuestion> GetAllBackstoryQuestions()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("backstory/questions")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<BackstoryQuestion>>(builder);
        }

        public ICollection<string> GetBackstoryQuestionIds()
        {
            return Retrieve<ICollection<string>>("backstory/questions");
        }

        public ICollection<BackstoryQuestion> GetBackstoryQuestions(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("backstory/questions")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<BackstoryQuestion>>(builder);
        }

        public BackstoryQuestion GetBackstoryQuestion(string id)
        {
            return Retrieve<BackstoryQuestion>($"backstory/questions/{id}");
        }

        public ICollection<Continent> GetAllContinents()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("continents")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<Continent>>(builder);
        }

        public ICollection<string> GetContinentIds()
        {
            return Retrieve<ICollection<string>>("continents");
        }

        public ICollection<Continent> GetContinents(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("continents")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Continent>>(builder);
        }

        public Continent GetContinent(string id)
        {
            return Retrieve<Continent>($"continents/{id}");
        }

        public ICollection<string> GetDungeonIds()
        {
            return Retrieve<ICollection<string>>("dungeons");
        }

        public ICollection<Dungeon> GetDungeons(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("dungeons")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Dungeon>>(builder);
        }

        public Dungeon GetDungeon(string id)
        {
            return Retrieve<Dungeon>($"dungeons/{id}");
        }

        public ICollection<string> GetMapIds()
        {
            return Retrieve<ICollection<string>>("maps");
        }

        public ICollection<Map> GetMaps(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("maps")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Map>>(builder);
        }

        public Map GetMap(string id)
        {
            return Retrieve<Map>($"maps/{id}");
        }

        public ICollection<string> GetMasteryIds()
        {
            return Retrieve<ICollection<string>>("masteries");
        }

        public ICollection<Mastery> GetMasteries(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("masteries")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Mastery>>(builder);
        }

        public Mastery GetMastery(string id)
        {
            return Retrieve<Mastery>($"masteries/{id}");
        }

        public ICollection<string> GetPetIds()
        {
            return Retrieve<ICollection<string>>("pets");
        }

        public ICollection<Pet> GetPets(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pets")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Pet>>(builder);
        }

        public Pet GetPet(string id)
        {
            return Retrieve<Pet>($"pets/{id}");
        }

        public ICollection<string> GetProfessionIds()
        {
            return Retrieve<ICollection<string>>("professions");
        }

        public ICollection<Profession> GetProfessions(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("professions")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Profession>>(builder);
        }

        public Profession GetProfession(string id)
        {
            return Retrieve<Profession>($"professions/{id}");
        }

        public ICollection<string> GetRaceIds()
        {
            return Retrieve<ICollection<string>>("races");
        }

        public ICollection<Race> GetRaces(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("races")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Race>>(builder);
        }

        public Race GetRace(string id)
        {
            return Retrieve<Race>($"races/{id}");
        }

        public ICollection<string> GetRaidIds()
        {
            return Retrieve<ICollection<string>>("raids");
        }

        public ICollection<Raid> GetRaids(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("raids")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Raid>>(builder);
        }

        public Raid GetRaid(string id)
        {
            return Retrieve<Raid>($"raids/{id}");
        }

        public ICollection<Specialization> GetSpecializations(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("specializations")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Specialization>>(builder);
        }

        public Specialization GetSpecialization(string id)
        {
            return Retrieve<Specialization>($"specializations/{id}");
        }

        public ICollection<string> GetStoryIds()
        {
            return Retrieve<ICollection<string>>("stories");
        }

        public ICollection<Story> GetStories(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("stories")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Story>>(builder);
        }

        public Story GetStory(string id)
        {
            return Retrieve<Story>($"stories/{id}");
        }

        public ICollection<string> GetStorySeasonIds()
        {
            return Retrieve<ICollection<string>>("stories/seasons");
        }

        public ICollection<StorySeason> GetStorySeasons(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("stories/seasons")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<StorySeason>>(builder);
        }

        public StorySeason GetStorySeason(string id)
        {
            return Retrieve<StorySeason>($"stories/seasons/{id}");
        }

        public ICollection<string> GetTraitIds()
        {
            return Retrieve<ICollection<string>>("traits");
        }

        public ICollection<Trait> GetTraits(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("traits")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Trait>>(builder);
        }

        public Trait GetTrait(string id)
        {
            return Retrieve<Trait>($"traits/{id}");
        }

        public ICollection<string> GetWorldIds()
        {
            return Retrieve<ICollection<string>>("worlds");
        }

        public ICollection<World> GetWorlds(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("worlds")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<World>>(builder);
        }

        public World GetWorld(string id)
        {
            return Retrieve<World>($"worlds/{id}");
        }

        #region Async
        public async Task<ICollection<BackstoryAnswer>> GetAllBackstoryAnswersAsync()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("backstory/answers")
                                                            .AddParameter("ids", "all");
            return await RetrieveAsync<ICollection<BackstoryAnswer>>(builder);
        }

        public async Task<ICollection<string>> GetBackstoryAnswerIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("backstory/answers");
        }

        public async Task<ICollection<BackstoryAnswer>> GetBackstoryAnswersAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("backstory/answers")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<BackstoryAnswer>>(builder);
        }

        public async Task<BackstoryAnswer> GetBackstoryAnswerAsync(string id)
        {
            return await RetrieveAsync<BackstoryAnswer>($"backstory/answers/{id}");
        }

        public async Task<ICollection<BackstoryQuestion>> GetAllBackstoryQuestionsAsync()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("backstory/questions")
                                                            .AddParameter("ids", "all");
            return await RetrieveAsync<ICollection<BackstoryQuestion>>(builder);
        }

        public async Task<ICollection<string>> GetBackstoryQuestionIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("backstory/questions");
        }

        public async Task<ICollection<BackstoryQuestion>> GetBackstoryQuestionsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("backstory/questions")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<BackstoryQuestion>>(builder);
        }

        public async Task<BackstoryQuestion> GetBackstoryQuestionAsync(string id)
        {
            return await RetrieveAsync<BackstoryQuestion>($"backstory/questions/{id}");
        }

        public async Task<ICollection<Continent>> GetAllContinentsAsync()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("continents")
                                                            .AddParameter("ids", "all");
            return await RetrieveAsync<ICollection<Continent>>(builder);
        }

        public async Task<ICollection<string>> GetContinentIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("continents");
        }

        public async Task<ICollection<Continent>> GetContinentsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("continents")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Continent>>(builder);
        }

        public async Task<Continent> GetContinentAsync(string id)
        {
            return await RetrieveAsync<Continent>($"continents/{id}");
        }

        public async Task<ICollection<string>> GetDungeonIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("dungeons");
        }

        public async Task<ICollection<Dungeon>> GetDungeonsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("dungeons")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Dungeon>>(builder);
        }

        public async Task<Dungeon> GetDungeonAsync(string id)
        {
            return await RetrieveAsync<Dungeon>($"dungeons/{id}");
        }

        public async Task<ICollection<string>> GetMapIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("maps");
        }

        public async Task<ICollection<Map>> GetMapsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("maps")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Map>>(builder);
        }

        public async Task<Map> GetMapAsync(string id)
        {
            return await RetrieveAsync<Map>($"maps/{id}");
        }

        public async Task<ICollection<string>> GetMasteryIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("masteries");
        }

        public async Task<ICollection<Mastery>> GetMasteriesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("masteries")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Mastery>>(builder);
        }

        public async Task<Mastery> GetMasteryAsync(string id)
        {
            return await RetrieveAsync<Mastery>($"masteries/{id}");
        }

        public async Task<ICollection<string>> GetPetIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("pets");
        }

        public async Task<ICollection<Pet>> GetPetsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pets")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Pet>>(builder);
        }

        public async Task<Pet> GetPetAsync(string id)
        {
            return await RetrieveAsync<Pet>($"pets/{id}");
        }

        public async Task<ICollection<string>> GetProfessionIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("professions");
        }

        public async Task<ICollection<Profession>> GetProfessionsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("professions")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Profession>>(builder);
        }

        public async Task<Profession> GetProfessionAsync(string id)
        {
            return await RetrieveAsync<Profession>($"professions/{id}");
        }

        public async Task<ICollection<string>> GetRaceIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("races");
        }

        public async Task<ICollection<Race>> GetRacesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("races")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Race>>(builder);
        }

        public async Task<Race> GetRaceAsync(string id)
        {
            return await RetrieveAsync<Race>($"races/{id}");
        }

        public async Task<ICollection<string>> GetRaidIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("raids");
        }

        public async Task<ICollection<Raid>> GetRaidsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("raids")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Raid>>(builder);
        }

        public async Task<Raid> GetRaidAsync(string id)
        {
            return await RetrieveAsync<Raid>($"raids/{id}");
        }

        public async Task<ICollection<Specialization>> GetSpecializationsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("specializations")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Specialization>>(builder);
        }

        public async Task<Specialization> GetSpecializationAsync(string id)
        {
            return await RetrieveAsync<Specialization>($"specializations/{id}");
        }

        public async Task<ICollection<string>> GetStoryIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("stories");
        }

        public async Task<ICollection<Story>> GetStoriesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("stories")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Story>>(builder);
        }

        public async Task<Story> GetStoryAsync(string id)
        {
            return await RetrieveAsync<Story>($"stories/{id}");
        }

        public async Task<ICollection<string>> GetStorySeasonIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("stories/seasons");
        }

        public async Task<ICollection<StorySeason>> GetStorySeasonsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("stories/seasons")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<StorySeason>>(builder);
        }

        public async Task<StorySeason> GetStorySeasonAsync(string id)
        {
            return await RetrieveAsync<StorySeason>($"stories/seasons/{id}");
        }

        public async Task<ICollection<string>> GetTraitIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("traits");
        }

        public async Task<ICollection<Trait>> GetTraitsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("traits")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Trait>>(builder);
        }

        public async Task<Trait> GetTraitAsync(string id)
        {
            return await RetrieveAsync<Trait>($"traits/{id}");
        }

        public async Task<ICollection<string>> GetWorldIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("worlds");
        }

        public async Task<ICollection<World>> GetWorldsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("worlds")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<World>>(builder);
        }

        public async Task<World> GetWorldAsync(string id)
        {
            return await RetrieveAsync<World>($"worlds/{id}");
        }
        #endregion
    }
}
