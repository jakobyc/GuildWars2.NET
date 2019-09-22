﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GuildWars2.NET.v2.PvE.Entities;

namespace GuildWars2.NET.v2.PvE.Repositories
{
    public interface IPvERepository
    {
        ICollection<BackstoryAnswer> GetAllBackstoryAnswers();
        Task<ICollection<BackstoryAnswer>> GetAllBackstoryAnswersAsync();
        ICollection<BackstoryQuestion> GetAllBackstoryQuestions();
        Task<ICollection<BackstoryQuestion>> GetAllBackstoryQuestionsAsync();
        ICollection<Continent> GetAllContinents();
        Task<ICollection<Continent>> GetAllContinentsAsync();
        BackstoryAnswer GetBackstoryAnswer(string id);
        Task<BackstoryAnswer> GetBackstoryAnswerAsync(string id);
        ICollection<string> GetBackstoryAnswerIds();
        Task<ICollection<string>> GetBackstoryAnswerIdsAsync();
        ICollection<BackstoryAnswer> GetBackstoryAnswers(params string[] ids);
        Task<ICollection<BackstoryAnswer>> GetBackstoryAnswersAsync(params string[] ids);
        BackstoryQuestion GetBackstoryQuestion(string id);
        Task<BackstoryQuestion> GetBackstoryQuestionAsync(string id);
        ICollection<string> GetBackstoryQuestionIds();
        Task<ICollection<string>> GetBackstoryQuestionIdsAsync();
        ICollection<BackstoryQuestion> GetBackstoryQuestions(params string[] ids);
        Task<ICollection<BackstoryQuestion>> GetBackstoryQuestionsAsync(params string[] ids);
        Continent GetContinent(string id);
        Task<Continent> GetContinentAsync(string id);
        ICollection<string> GetContinentIds();
        Task<ICollection<string>> GetContinentIdsAsync();
        ICollection<Continent> GetContinents(params string[] ids);
        Task<ICollection<Continent>> GetContinentsAsync(params string[] ids);
        Dungeon GetDungeon(string id);
        Task<Dungeon> GetDungeonAsync(string id);
        ICollection<string> GetDungeonIds();
        Task<ICollection<string>> GetDungeonIdsAsync();
        ICollection<Dungeon> GetDungeons(params string[] ids);
        Task<ICollection<Dungeon>> GetDungeonsAsync(params string[] ids);
        Map GetMap(string id);
        Task<Map> GetMapAsync(string id);
        ICollection<string> GetMapIds();
        Task<ICollection<string>> GetMapIdsAsync();
        ICollection<Map> GetMaps(params string[] ids);
        Task<ICollection<Map>> GetMapsAsync(params string[] ids);
        ICollection<Mastery> GetMasteries(params string[] ids);
        Task<ICollection<Mastery>> GetMasteriesAsync(params string[] ids);
        Mastery GetMastery(string id);
        Task<Mastery> GetMasteryAsync(string id);
        ICollection<string> GetMasteryIds();
        Task<ICollection<string>> GetMasteryIdsAsync();
        Pet GetPet(string id);
        Task<Pet> GetPetAsync(string id);
        ICollection<string> GetPetIds();
        Task<ICollection<string>> GetPetIdsAsync();
        ICollection<Pet> GetPets(params string[] ids);
        Task<ICollection<Pet>> GetPetsAsync(params string[] ids);
        Profession GetProfession(string id);
        Task<Profession> GetProfessionAsync(string id);
        ICollection<string> GetProfessionIds();
        Task<ICollection<string>> GetProfessionIdsAsync();
        ICollection<Profession> GetProfessions(params string[] ids);
        Task<ICollection<Profession>> GetProfessionsAsync(params string[] ids);
        Race GetRace(string id);
        Task<Race> GetRaceAsync(string id);
        ICollection<string> GetRaceIds();
        Task<ICollection<string>> GetRaceIdsAsync();
        ICollection<Race> GetRaces(params string[] ids);
        Task<ICollection<Race>> GetRacesAsync(params string[] ids);
        Raid GetRaid(string id);
        Task<Raid> GetRaidAsync(string id);
        ICollection<string> GetRaidIds();
        Task<ICollection<string>> GetRaidIdsAsync();
        ICollection<Raid> GetRaids(params string[] ids);
        Task<ICollection<Raid>> GetRaidsAsync(params string[] ids);
        Specialization GetSpecialization(string id);
        Task<Specialization> GetSpecializationAsync(string id);
        ICollection<Specialization> GetSpecializations(params string[] ids);
        Task<ICollection<Specialization>> GetSpecializationsAsync(params string[] ids);
        ICollection<Story> GetStories(params string[] ids);
        Task<ICollection<Story>> GetStoriesAsync(params string[] ids);
        Story GetStory(string id);
        Task<Story> GetStoryAsync(string id);
        ICollection<string> GetStoryIds();
        Task<ICollection<string>> GetStoryIdsAsync();
        StorySeason GetStorySeason(string id);
        Task<StorySeason> GetStorySeasonAsync(string id);
        ICollection<string> GetStorySeasonIds();
        Task<ICollection<string>> GetStorySeasonIdsAsync();
        ICollection<StorySeason> GetStorySeasons(params string[] ids);
        Task<ICollection<StorySeason>> GetStorySeasonsAsync(params string[] ids);
        Trait GetTrait(string id);
        Task<Trait> GetTraitAsync(string id);
        ICollection<string> GetTraitIds();
        Task<ICollection<string>> GetTraitIdsAsync();
        ICollection<Trait> GetTraits(params string[] ids);
        Task<ICollection<Trait>> GetTraitsAsync(params string[] ids);
        World GetWorld(string id);
        Task<World> GetWorldAsync(string id);
        ICollection<string> GetWorldIds();
        Task<ICollection<string>> GetWorldIdsAsync();
        ICollection<World> GetWorlds(params string[] ids);
        Task<ICollection<World>> GetWorldsAsync(params string[] ids);
    }
}