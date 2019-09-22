﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GuildWars2.NET.v2.PvP.Entities;

namespace GuildWars2.NET.v2.PvP.Repositories
{
    public interface IPvPRepository
    {
        ICollection<PvPAmulet> GetAllAmulets();
        Task<ICollection<PvPAmulet>> GetAllAmuletsAsync();
        ICollection<PvPHero> GetAllHeroes();
        Task<ICollection<PvPHero>> GetAllHeroesAsync();
        ICollection<PvPRank> GetAllPvPRanks();
        Task<ICollection<PvPRank>> GetAllPvPRanksAsync();
        PvPAmulet GetAmulet(string id);
        Task<PvPAmulet> GetAmuletAsync(string id);
        ICollection<string> GetAmuletIds();
        Task<ICollection<string>> GetAmuletIdsAsync();
        ICollection<PvPAmulet> GetAmulets(params string[] ids);
        Task<ICollection<PvPAmulet>> GetAmuletsAsync(params string[] ids);
        string[] GetEndpoints();
        Task<string[]> GetEndpointsAsync();
        PvPHero GetHero(string id);
        Task<PvPHero> GetHeroAsync(string id);
        ICollection<PvPHero> GetHeroes(params string[] ids);
        Task<ICollection<PvPHero>> GetHeroesAsync(params string[] ids);
        ICollection<string> GetHeroIds();
        Task<ICollection<string>> GetHeroIdsAsync();
        ICollection<LeaderboardItem> GetLeaderboardsEU(string id);
        Task<ICollection<LeaderboardItem>> GetLeaderboardsEUAsync(string id);
        ICollection<LeaderboardItem> GetLeaderboardsNA(string id);
        Task<ICollection<LeaderboardItem>> GetLeaderboardsNAAsync(string id);
        Match GetMatch(string id);
        Task<Match> GetMatchAsync(string id);
        ICollection<Match> GetMatches(params string[] ids);
        Task<ICollection<Match>> GetMatchesAsync(params string[] ids);
        ICollection<string> GetMatchIds();
        Task<ICollection<string>> GetMatchIdsAsync();
        MatchOverview GetMatchOverview(string worldId);
        Task<MatchOverview> GetMatchOverviewAsync(string worldId);
        MatchScores GetMatchScores(string worldId);
        Task<MatchScores> GetMatchScoresAsync(string worldId);
        MatchStats GetMatchStats(string worldId);
        Task<MatchStats> GetMatchStatsAsync(string worldId);
        WvWObjective GetObjective(string objectiveId);
        Task<WvWObjective> GetObjectiveAsync(string objectiveId);
        ICollection<string> GetObjectiveIds();
        Task<ICollection<string>> GetObjectiveIdsAsync();
        ICollection<WvWObjective> GetObjectives(params string[] objectiveIds);
        Task<ICollection<WvWObjective>> GetObjectivesAsync(params string[] objectiveIds);
        PvPRank GetPvPRank(string id);
        Task<PvPRank> GetPvPRankAsync(string id);
        ICollection<string> GetPvPRankIds();
        Task<ICollection<string>> GetPvPRankIdsAsync();
        ICollection<PvPRank> GetPvPRanks(params string[] ids);
        Task<ICollection<PvPRank>> GetPvPRanksAsync(params string[] ids);
        PvPSeason GetPvPSeason(string id);
        Task<PvPSeason> GetPvPSeasonAsync(string id);
        ICollection<string> GetPvPSeasonIds();
        Task<ICollection<string>> GetPvPSeasonIdsAsync();
        ICollection<PvPSeason> GetPvPSeasons(params string[] ids);
        Task<ICollection<PvPSeason>> GetPvPSeasonsAsync(params string[] ids);
        ICollection<GuildStats> GetTopGuildKDR(string matchId, WvWTeam team);
        Task<ICollection<GuildStats>> GetTopGuildKDRAsync(string matchId, WvWTeam team);
        ICollection<GuildStats> GetTopGuildKills(string matchId, WvWTeam team);
        Task<ICollection<GuildStats>> GetTopGuildKillsAsync(string matchId, WvWTeam team);
        ICollection<WvWAbility> GetWvWAbilities(params string[] ids);
        Task<ICollection<WvWAbility>> GetWvWAbilitiesAsync(params string[] ids);
        WvWAbility GetWvWAbility(string id);
        Task<WvWAbility> GetWvWAbilityAsync(string id);
        ICollection<string> GetWvWAbilityIds();
        Task<ICollection<string>> GetWvWAbilityIdsAsync();
        WvWRank GetWvWRank(string id);
        Task<WvWRank> GetWvWRankAsync(string id);
        ICollection<string> GetWvWRankIds();
        Task<ICollection<string>> GetWvWRankIdsAsync();
        ICollection<WvWRank> GetWvWRanks(params string[] ids);
        Task<ICollection<WvWRank>> GetWvWRanksAsync(params string[] ids);
        WvWUpgrade GetWvWUpgrade(string id);
        Task<WvWUpgrade> GetWvWUpgradeAsync(string id);
        ICollection<string> GetWvWUpgradeIds();
        Task<ICollection<string>> GetWvWUpgradeIdsAsync();
        ICollection<WvWUpgrade> GetWvWUpgrades(params string[] ids);
        Task<ICollection<WvWUpgrade>> GetWvWUpgradesAsync(params string[] ids);
    }
}