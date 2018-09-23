using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.v2.PvP.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.PvP.Repositories
{
    public enum WvWTeam
    {
        Blue,
        Green,
        Red
    }

    public class PvPRepository : GW2Repository
    {
        public PvPRepository() : base() { }
 
        public ICollection<PvPAmulet> GetAllAmulets()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/amulets")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<PvPAmulet>>(builder);
        }

        public ICollection<string> GetAmuletIds()
        {
            return Retrieve<ICollection<string>>("pvp/amulets");
        }

        public ICollection<PvPAmulet> GetAmulets(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/amulets")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<PvPAmulet>>(builder);
        }

        public PvPAmulet GetAmulet(string id)
        {
            return Retrieve<PvPAmulet>($"pvp/amulets/{id}");
        }

        public string[] GetEndpoints()
        {
            return Retrieve<string[]>($"pvp");
        }

        public ICollection<PvPHero> GetAllHeroes()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/heroes")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<PvPHero>>(builder);
        }

        public ICollection<string> GetHeroIds()
        {
            return Retrieve<ICollection<string>>("pvp/heroes");
        }

        public ICollection<PvPHero> GetHeroes(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/heroes")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<PvPHero>>(builder);
        }

        public PvPHero GetHero(string id)
        {
            return Retrieve<PvPHero>($"pvp/heroes/{id}");
        }

        /// <summary>
        /// Get the leaderboards for a season.
        /// </summary>
        /// <param name="id">Season ID</param>
        /// <returns></returns>
        public ICollection<LeaderboardItem> GetLeaderboardsEU(string id)
        {
            return Retrieve<ICollection<LeaderboardItem>>($"pvp/seasons/{id}/leaderboards/ladder/eu");
        }

        public ICollection<LeaderboardItem> GetLeaderboardsNA(string id)
        {
            return Retrieve<ICollection<LeaderboardItem>>($"pvp/seasons/{id}/leaderboards/ladder/na");
        }

        public Match GetMatch(string id)
        {
            return Retrieve<Match>($"wvw/matches/{id}");
        }

        public MatchOverview GetMatchOverview(string worldId)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/matches/overview")
                                                            .AddParameter("world", worldId);
            return Retrieve<MatchOverview>(builder);
        }

        public MatchScores GetMatchScores(string worldId)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/matches/scores")
                                                            .AddParameter("world", worldId);
            return Retrieve<MatchScores>(builder);
        }

        public MatchStats GetMatchStats(string worldId)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/matches/stats")
                                                            .AddParameter("world", worldId);
            return Retrieve<MatchStats>(builder);
        }

        public ICollection<string> GetMatchIds()
        {
            return Retrieve<ICollection<string>>("wvw/matches");
        }

        public ICollection<Match> GetMatches(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/matches")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Match>>(builder);
        }

        public ICollection<string> GetObjectiveIds()
        {
            return Retrieve<ICollection<string>>("wvw/objectives");
        }

        public WvWObjective GetObjective(string objectiveId)
        {
            return Retrieve<WvWObjective>($"wvw/objectives/{objectiveId}");
        }

        public ICollection<WvWObjective> GetObjectives(params string[] objectiveIds)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/objectives")
                                                            .AddParameter("ids", objectiveIds);
            return Retrieve<ICollection<WvWObjective>>(builder);
        }

        public ICollection<PvPRank> GetAllPvPRanks()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/ranks")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<PvPRank>>(builder);
        }

        public ICollection<string> GetPvPRankIds()
        {
            return Retrieve<ICollection<string>>("pvp/ranks");
        }

        public ICollection<PvPRank> GetPvPRanks(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/ranks")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<PvPRank>>(builder);
        }

        public PvPRank GetPvPRank(string id)
        {
            return Retrieve<PvPRank>($"pvp/ranks/{id}");
        }

        public ICollection<string> GetPvPSeasonIds()
        {
            return Retrieve<ICollection<string>>("pvp/seasons");
        }

        public ICollection<PvPSeason> GetPvPSeasons(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/seasons")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<PvPSeason>>(builder);
        }

        public PvPSeason GetPvPSeason(string id)
        {
            return Retrieve<PvPSeason>($"pvp/seasons/{id}");
        }

        public ICollection<GuildStats> GetTopGuildKDR(string matchId, WvWTeam team)
        {
            return Retrieve<ICollection<GuildStats>>($"wvw/matches/stats/{matchId}/teams/{GetTeam(team)}/top/kdr");
        }

        public ICollection<GuildStats> GetTopGuildKills(string matchId, WvWTeam team)
        {
            return Retrieve<ICollection<GuildStats>>($"wvw/matches/stats/{matchId}/teams/{GetTeam(team)}/top/kills");
        }

        public WvWAbility GetWvWAbility(string id)
        {
            return Retrieve<WvWAbility>($"wvw/abilities/{id}");
        }

        public ICollection<string> GetWvWAbilityIds()
        {
            return Retrieve<ICollection<string>>("wvw/abilities");
        }

        public ICollection<WvWAbility> GetWvWAbilities(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/abilities")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<WvWAbility>>(builder);
        }

        public ICollection<string> GetWvWRankIds()
        {
            return Retrieve<ICollection<string>>("wvw/ranks");
        }

        public ICollection<WvWRank> GetWvWRanks(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/ranks")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<WvWRank>>(builder);
        }

        public WvWRank GetWvWRank(string id)
        {
            return Retrieve<WvWRank>($"wvw/ranks/{id}");
        }

        public ICollection<string> GetWvWUpgradeIds()
        {
            return Retrieve<ICollection<string>>("wvw/upgrades");
        }

        public ICollection<WvWUpgrade> GetWvWUpgrades(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/upgrades")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<WvWUpgrade>>(builder);
        }

        public WvWUpgrade GetWvWUpgrade(string id)
        {
            return Retrieve<WvWUpgrade>($"wvw/upgrades/{id}");
        }


        #region Async
        public async Task<ICollection<PvPAmulet>> GetAllAmuletsAsync()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/amulets")
                                                            .AddParameter("ids", "all");
            return await RetrieveAsync<ICollection<PvPAmulet>>(builder);
        }

        public async Task<ICollection<string>> GetAmuletIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("pvp/amulets");
        }

        public async Task<ICollection<PvPAmulet>> GetAmuletsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/amulets")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<PvPAmulet>>(builder);
        }

        public async Task<PvPAmulet> GetAmuletAsync(string id)
        {
            return await RetrieveAsync<PvPAmulet>($"pvp/amulets/{id}");
        }

        public async Task<string[]> GetEndpointsAsync()
        {
            return await RetrieveAsync<string[]>($"pvp");
        }

        public async Task<ICollection<PvPHero>> GetAllHeroesAsync()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/heroes")
                                                            .AddParameter("ids", "all");
            return await RetrieveAsync<ICollection<PvPHero>>(builder);
        }

        public async Task<ICollection<string>> GetHeroIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("pvp/heroes");
        }

        public async Task<ICollection<PvPHero>> GetHeroesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/heroes")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<PvPHero>>(builder);
        }

        public async Task<PvPHero> GetHeroAsync(string id)
        {
            return await RetrieveAsync<PvPHero>($"pvp/heroes/{id}");
        }

        /// <summary>
        /// Get the leaderboards for a season.
        /// </summary>
        /// <param name="id">Season ID</param>
        /// <returns></returns>
        public async Task<ICollection<LeaderboardItem>> GetLeaderboardsEUAsync(string id)
        {
            return await RetrieveAsync<ICollection<LeaderboardItem>>($"pvp/seasons/{id}/leaderboards/ladder/eu");
        }

        public async Task<ICollection<LeaderboardItem>> GetLeaderboardsNAAsync(string id)
        {
            return await RetrieveAsync<ICollection<LeaderboardItem>>($"pvp/seasons/{id}/leaderboards/ladder/na");
        }

        public async Task<Match> GetMatchAsync(string id)
        {
            return await RetrieveAsync<Match>($"wvw/matches/{id}");
        }

        public async Task<MatchOverview> GetMatchOverviewAsync(string worldId)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/matches/overview")
                                                            .AddParameter("world", worldId);
            return await RetrieveAsync<MatchOverview>(builder);
        }

        public async Task<MatchScores> GetMatchScoresAsync(string worldId)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/matches/scores")
                                                            .AddParameter("world", worldId);
            return await RetrieveAsync<MatchScores>(builder);
        }

        public async Task<MatchStats> GetMatchStatsAsync(string worldId)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/matches/stats")
                                                            .AddParameter("world", worldId);
            return await RetrieveAsync<MatchStats>(builder);
        }

        public async Task<ICollection<string>> GetMatchIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("wvw/matches");
        }

        public async Task<ICollection<Match>> GetMatchesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/matches")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Match>>(builder);
        }

        public async Task<ICollection<string>> GetObjectiveIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("wvw/objectives");
        }

        public async Task<WvWObjective> GetObjectiveAsync(string objectiveId)
        {
            return await RetrieveAsync<WvWObjective>($"wvw/objectives/{objectiveId}");
        }

        public async Task<ICollection<WvWObjective>> GetObjectivesAsync(params string[] objectiveIds)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/objectives")
                                                            .AddParameter("ids", objectiveIds);
            return await RetrieveAsync<ICollection<WvWObjective>>(builder);
        }

        public async Task<ICollection<PvPRank>> GetAllPvPRanksAsync()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/ranks")
                                                            .AddParameter("ids", "all");
            return await RetrieveAsync<ICollection<PvPRank>>(builder);
        }

        public async Task<ICollection<string>> GetPvPRankIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("pvp/ranks");
        }

        public async Task<ICollection<PvPRank>> GetPvPRanksAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/ranks")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<PvPRank>>(builder);
        }

        public async Task<PvPRank> GetPvPRankAsync(string id)
        {
            return await RetrieveAsync<PvPRank>($"pvp/ranks/{id}");
        }

        public async Task<ICollection<string>> GetPvPSeasonIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("pvp/seasons");
        }

        public async Task<ICollection<PvPSeason>> GetPvPSeasonsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/seasons")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<PvPSeason>>(builder);
        }

        public async Task<PvPSeason> GetPvPSeasonAsync(string id)
        {
            return await RetrieveAsync<PvPSeason>($"pvp/seasons/{id}");
        }

        public async Task<ICollection<GuildStats>> GetTopGuildKDRAsync(string matchId, WvWTeam team)
        {
            return await RetrieveAsync<ICollection<GuildStats>>($"wvw/matches/stats/{matchId}/teams/{GetTeam(team)}/top/kdr");
        }

        public async Task<ICollection<GuildStats>> GetTopGuildKillsAsync(string matchId, WvWTeam team)
        {
            return await RetrieveAsync<ICollection<GuildStats>>($"wvw/matches/stats/{matchId}/teams/{GetTeam(team)}/top/kills");
        }

        public async Task<WvWAbility> GetWvWAbilityAsync(string id)
        {
            return await RetrieveAsync<WvWAbility>($"wvw/abilities/{id}");
        }

        public async Task<ICollection<string>> GetWvWAbilityIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("wvw/abilities");
        }

        public async Task<ICollection<WvWAbility>> GetWvWAbilitiesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/abilities")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<WvWAbility>>(builder);
        }

        public async Task<ICollection<string>> GetWvWRankIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("wvw/ranks");
        }

        public async Task<ICollection<WvWRank>> GetWvWRanksAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/ranks")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<WvWRank>>(builder);
        }

        public async Task<WvWRank> GetWvWRankAsync(string id)
        {
            return await RetrieveAsync<WvWRank>($"wvw/ranks/{id}");
        }

        public async Task<ICollection<string>> GetWvWUpgradeIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("wvw/upgrades");
        }

        public async Task<ICollection<WvWUpgrade>> GetWvWUpgradesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/upgrades")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<WvWUpgrade>>(builder);
        }

        public async Task<WvWUpgrade> GetWvWUpgradeAsync(string id)
        {
            return await RetrieveAsync<WvWUpgrade>($"wvw/upgrades/{id}");
        }
        #endregion

        private string GetTeam(WvWTeam team)
        {
            switch(team)
            {
                case (WvWTeam.Blue):
                    return "blue";
                case (WvWTeam.Green):
                    return "green";
                case (WvWTeam.Red):
                    return "red";
            }
            return string.Empty;
        }
    }
}
