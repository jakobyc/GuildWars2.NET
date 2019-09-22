using GuildWars2.NET.v2.PvP.Repositories;
using GuildWars2.NET.v2.PvP.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class PvPTest : ApiTest
    {
        private readonly IPvPRepository repository;

        public PvPTest()
        {
            this.repository = Client.PvP;
        }

        [Fact]
        public void GetAllAmulets()
        {
            AssertCall<List<PvPAmulet>>(repository.GetAllAmulets());
        }

        [Fact]
        public void GetAmuletIds()
        {
            AssertIds<List<string>>(repository.GetAmuletIds());
        }

        [Theory]
        [InlineData("1", "4")]
        public void GetAmulets(params string[] ids)
        {
            AssertCall<List<PvPAmulet>>(repository.GetAmulets(ids));
        }

        [Theory]
        [InlineData("5")]
        public void GetAmulet(string id)
        {
            AssertCall<PvPAmulet>(repository.GetAmulet(id));
        }

        [Fact]
        public void GetEndpoint()
        {
            AssertCall<string[]>(repository.GetEndpoints());
        }

        [Fact]
        public void GetAllHeroes()
        {
            AssertCall<List<PvPHero>>(repository.GetAllHeroes());
        }

        [Fact]
        public void GetHeroIds()
        {
            AssertIds<List<string>>(repository.GetHeroIds());
        }

        [Theory]
        [InlineData("115C140F-C2F5-40EB-8EA2-C3773F2AE468", "B7EA9889-5F16-4636-9705-4FCAF8B39ECD")]
        public void GetHeroes(params string[] ids)
        {
            AssertCall<List<PvPHero>>(repository.GetHeroes(ids));
        }

        [Theory]
        [InlineData("115C140F-C2F5-40EB-8EA2-C3773F2AE468")]
        public void GetHero(string id)
        {
            AssertCall<PvPHero>(repository.GetHero(id));
        }

        [Theory]
        [InlineData("A54849B7-7DBD-4958-91EF-72E18CD659BA")]
        public void GetLeaderboardsEU(string id)
        {
            AssertCall<List<LeaderboardItem>>(repository.GetLeaderboardsEU(id));
        }

        [Theory]
        [InlineData("A54849B7-7DBD-4958-91EF-72E18CD659BA")]
        public void GetLeaderboardsNA(string id)
        {
            AssertCall<List<LeaderboardItem>>(repository.GetLeaderboardsNA(id));
        }

        [Theory]
        [InlineData("1-1")]
        public void GetMatch(string id)
        {
            AssertCall<Match>(repository.GetMatch(id));
        }

        [Theory]
        [InlineData("1008")]
        public void GetMatchOverview(string worldId)
        {
            AssertCall<MatchOverview>(repository.GetMatchOverview(worldId));
        }

        [Theory]
        [InlineData("1008")]
        public void GetMatchScores(string worldId)
        {
            AssertCall<MatchScores>(repository.GetMatchScores(worldId));
        }

        [Theory]
        [InlineData("1008")]
        public void GetMatchStats(string worldId)
        {
            AssertCall<MatchStats>(repository.GetMatchStats(worldId));
        }

        [Fact]
        public void GetMatchIds()
        {
            AssertIds<List<string>>(repository.GetMatchIds());
        }

        [Theory]
        [InlineData("1-1", "2-1")]
        public void GetMatches(params string[] ids)
        {
            AssertCall<List<Match>>(repository.GetMatches(ids));
        }

        [Fact]
        public void GetObjectiveIds()
        {
            AssertIds<List<string>>(repository.GetObjectiveIds());
        }

        [Theory]
        [InlineData("1099-99")]
        public void GetObjective(string id)
        {
            AssertCall<WvWObjective>(repository.GetObjective(id));
        }

        [Theory]
        [InlineData("1099-99", "96-35")]
        public void GetObjectives(params string[] ids)
        {
            AssertCall<List<WvWObjective>>(repository.GetObjectives(ids));
        }

        [Fact]
        public void GetAllPvPRanks()
        {
            AssertCall<List<PvPRank>>(repository.GetAllPvPRanks());
        }

        [Fact]
        public void GetPvPRankIds()
        {
            AssertIds<List<string>>(repository.GetPvPRankIds());
        }

        [Theory]
        [InlineData("1", "2")]
        public void GetPvPRanks(params string[] ids)
        {
            AssertCall<List<PvPRank>>(repository.GetPvPRanks(ids));
        }

        [Theory]
        [InlineData("3")]
        public void GetPvPRank(string id)
        {
            AssertCall<PvPRank>(repository.GetPvPRank(id));
        }

        [Fact]
        public void GetPvPSeasonIds()
        {
            AssertIds<List<string>>(repository.GetPvPSeasonIds());
        }

        [Theory]
        [InlineData("44B85826-B5ED-4890-8C77-82DDF9F2CF2B", "95D5B290-798A-421E-A919-1C2A75F74B72")]
        public void GetPvPSeasons(params string[] ids)
        {
            AssertCall<List<PvPSeason>>(repository.GetPvPSeasons(ids));
        }

        [Theory]
        [InlineData("44B85826-B5ED-4890-8C77-82DDF9F2CF2B")]
        public void GetPvPSeason(string id)
        {
            AssertCall<PvPSeason>(repository.GetPvPSeason(id));
        }

        [Theory]
        [InlineData("1-1", WvWTeam.Red)]
        public void GetTopGuildKDR(string matchId, WvWTeam team)
        {
            AssertCall<List<GuildStats>>(repository.GetTopGuildKDR(matchId, team));
        }

        [Theory]
        [InlineData("1-1", WvWTeam.Red)]
        public void GetTopGuildKills(string matchId, WvWTeam team)
        {
            AssertCall<List<GuildStats>>(repository.GetTopGuildKills(matchId, team));
        }

        [Theory]
        [InlineData("2")]
        public void GetWvWAbility(string id)
        {
            AssertCall<WvWAbility>(repository.GetWvWAbility(id));
        }

        [Fact]
        public void GetWvWAbilityIds()
        {
            AssertIds<List<string>>(repository.GetWvWAbilityIds());
        }

        [Theory]
        [InlineData("4", "24")]
        public void GetWvWAbilities(params string[] ids)
        {
            AssertCall<List<WvWAbility>>(repository.GetWvWAbilities(ids));
        }

        [Fact]
        public void GetWvWRankIds()
        {
            AssertIds<List<string>>(repository.GetWvWRankIds());
        }

        [Theory]
        [InlineData("20", "21", "30", "105")]
        public void GetWvWRanks(params string[] ids)
        {
            AssertCall<List<WvWRank>>(repository.GetWvWRanks(ids));
        }

        [Theory]
        [InlineData("20")]
        public void GetWvWRank(string id)
        {
            AssertCall<WvWRank>(repository.GetWvWRank(id));
        }

        [Fact]
        public void GetWvWUpgradeIds()
        {
            AssertIds<List<string>>(repository.GetWvWUpgradeIds());
        }

        [Theory]
        [InlineData("15", "16", "17")]
        public void GetWvWUpgrades(params string[] ids)
        {
            AssertCall<List<WvWUpgrade>>(repository.GetWvWUpgrades(ids));
        }

        [Theory]
        [InlineData("5")]
        public void GetWvWUpgrade(string id)
        {
            AssertCall<WvWUpgrade>(repository.GetWvWUpgrade(id));
        }

        #region Async

        [Fact]
        public async Task GetAllAmuletsAsync()
        {
            AssertCall<List<PvPAmulet>>(await repository.GetAllAmuletsAsync());
        }

        [Fact]
        public async Task GetAmuletIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetAmuletIdsAsync());
        }

        [Theory]
        [InlineData("1", "4")]
        public async Task GetAmuletsAsync(params string[] ids)
        {
            AssertCall<List<PvPAmulet>>(await repository.GetAmuletsAsync(ids));
        }

        [Theory]
        [InlineData("5")]
        public async Task GetAmuletAsync(string id)
        {
            AssertCall<PvPAmulet>(await repository.GetAmuletAsync(id));
        }

        [Fact]
        public async Task GetEndpointAsync()
        {
            AssertCall<string[]>(await repository.GetEndpointsAsync());
        }

        [Fact]
        public async Task GetAllHeroesAsync()
        {
            AssertCall<List<PvPHero>>(await repository.GetAllHeroesAsync());
        }

        [Fact]
        public async Task GetHeroIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetHeroIdsAsync());
        }

        [Theory]
        [InlineData("115C140F-C2F5-40EB-8EA2-C3773F2AE468", "B7EA9889-5F16-4636-9705-4FCAF8B39ECD")]
        public async Task GetHeroesAsync(params string[] ids)
        {
            AssertCall<List<PvPHero>>(await repository.GetHeroesAsync(ids));
        }

        [Theory]
        [InlineData("115C140F-C2F5-40EB-8EA2-C3773F2AE468")]
        public async Task GetHeroAsync(string id)
        {
            AssertCall<PvPHero>(await repository.GetHeroAsync(id));
        }

        [Theory]
        [InlineData("A54849B7-7DBD-4958-91EF-72E18CD659BA")]
        public async Task GetLeaderboardsEUAsync(string id)
        {
            AssertCall<List<LeaderboardItem>>(await repository.GetLeaderboardsEUAsync(id));
        }

        [Theory]
        [InlineData("A54849B7-7DBD-4958-91EF-72E18CD659BA")]
        public async Task GetLeaderboardsNAAsync(string id)
        {
            AssertCall<List<LeaderboardItem>>(await repository.GetLeaderboardsNAAsync(id));
        }

        [Theory]
        [InlineData("1-1")]
        public async Task GetMatchAsync(string id)
        {
            AssertCall<Match>(await repository.GetMatchAsync(id));
        }

        [Theory]
        [InlineData("1008")]
        public async Task GetMatchOverviewAsync(string worldId)
        {
            AssertCall<MatchOverview>(await repository.GetMatchOverviewAsync(worldId));
        }

        [Theory]
        [InlineData("1008")]
        public async Task GetMatchScoresAsync(string worldId)
        {
            AssertCall<MatchScores>(await repository.GetMatchScoresAsync(worldId));
        }

        [Theory]
        [InlineData("1008")]
        public async Task GetMatchStatsAsync(string worldId)
        {
            AssertCall<MatchStats>(await repository.GetMatchStatsAsync(worldId));
        }

        [Fact]
        public async Task GetMatchIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetMatchIdsAsync());
        }

        [Theory]
        [InlineData("1-1", "2-1")]
        public async Task GetMatchesAsync(params string[] ids)
        {
            AssertCall<List<Match>>(await repository.GetMatchesAsync(ids));
        }

        [Fact]
        public async Task GetObjectiveIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetObjectiveIdsAsync());
        }

        [Theory]
        [InlineData("1099-99")]
        public async Task GetObjectiveAsync(string id)
        {
            AssertCall<WvWObjective>(await repository.GetObjectiveAsync(id));
        }

        [Theory]
        [InlineData("1099-99", "96-35")]
        public async Task GetObjectivesAsync(params string[] ids)
        {
            AssertCall<List<WvWObjective>>(await repository.GetObjectivesAsync(ids));
        }

        [Fact]
        public async Task GetAllPvPRanksAsync()
        {
            AssertCall<List<PvPRank>>(await repository.GetAllPvPRanksAsync());
        }

        [Fact]
        public async Task GetPvPRankIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetPvPRankIdsAsync());
        }

        [Theory]
        [InlineData("1", "2")]
        public async Task GetPvPRanksAsync(params string[] ids)
        {
            AssertCall<List<PvPRank>>(await repository.GetPvPRanksAsync(ids));
        }

        [Theory]
        [InlineData("3")]
        public async Task GetPvPRankAsync(string id)
        {
            AssertCall<PvPRank>(await repository.GetPvPRankAsync(id));
        }

        [Fact]
        public async Task GetPvPSeasonIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetPvPSeasonIdsAsync());
        }

        [Theory]
        [InlineData("44B85826-B5ED-4890-8C77-82DDF9F2CF2B", "95D5B290-798A-421E-A919-1C2A75F74B72")]
        public async Task GetPvPSeasonsAsync(params string[] ids)
        {
            AssertCall<List<PvPSeason>>(await repository.GetPvPSeasonsAsync(ids));
        }

        [Theory]
        [InlineData("44B85826-B5ED-4890-8C77-82DDF9F2CF2B")]
        public async Task GetPvPSeasonAsync(string id)
        {
            AssertCall<PvPSeason>(await repository.GetPvPSeasonAsync(id));
        }

        [Theory]
        [InlineData("1-1", WvWTeam.Red)]
        public async Task GetTopGuildKDRAsync(string matchId, WvWTeam team)
        {
            AssertCall<List<GuildStats>>(await repository.GetTopGuildKDRAsync(matchId, team));
        }

        [Theory]
        [InlineData("1-1", WvWTeam.Red)]
        public async Task GetTopGuildKillsAsync(string matchId, WvWTeam team)
        {
            AssertCall<List<GuildStats>>(await repository.GetTopGuildKillsAsync(matchId, team));
        }

        [Theory]
        [InlineData("2")]
        public async Task GetWvWAbilityAsync(string id)
        {
            AssertCall<WvWAbility>(await repository.GetWvWAbilityAsync(id));
        }

        [Fact]
        public async Task GetWvWAbilityIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetWvWAbilityIdsAsync());
        }

        [Theory]
        [InlineData("4", "24")]
        public async Task GetWvWAbilitiesAsync(params string[] ids)
        {
            AssertCall<List<WvWAbility>>(await repository.GetWvWAbilitiesAsync(ids));
        }

        [Fact]
        public async Task GetWvWRankIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetWvWRankIdsAsync());
        }

        [Theory]
        [InlineData("20", "21", "30", "105")]
        public async Task GetWvWRanksAsync(params string[] ids)
        {
            AssertCall<List<WvWRank>>(await repository.GetWvWRanksAsync(ids));
        }

        [Theory]
        [InlineData("20")]
        public async Task GetWvWRankAsync(string id)
        {
            AssertCall<WvWRank>(await repository.GetWvWRankAsync(id));
        }

        [Fact]
        public async Task GetWvWUpgradeIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetWvWUpgradeIdsAsync());
        }

        [Theory]
        [InlineData("15", "16", "17")]
        public async Task GetWvWUpgradesAsync(params string[] ids)
        {
            AssertCall<List<WvWUpgrade>>(await repository.GetWvWUpgradesAsync(ids));
        }

        [Theory]
        [InlineData("5")]
        public async Task GetWvWUpgradeAsync(string id)
        {
            AssertCall<WvWUpgrade>(await repository.GetWvWUpgradeAsync(id));
        }
        #endregion
    }
}
