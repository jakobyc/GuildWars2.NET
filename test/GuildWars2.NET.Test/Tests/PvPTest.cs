using GuildWars2.NET.v2.PvP.Repositories;
using GuildWars2.NET.Test.Dependencies;
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
        private PvPRepository repository;

        public PvPTest(RepositoryFactory factory)
        {
            this.repository = factory.GetPvPRepository();
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
        [InlineData("1-1")]
        public async Task GetMatchAsync(string id)
        {
            AssertCall<Match>(await repository.GetMatchAsync(id));
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
        [InlineData("15")]
        public void GetWvWUpgrade(string id)
        {
            AssertCall<WvWUpgrade>(repository.GetWvWUpgrade(id));
        }
    }
}
