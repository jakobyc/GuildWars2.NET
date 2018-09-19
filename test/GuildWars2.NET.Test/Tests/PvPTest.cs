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
        public void GetAmulets()
        {
            AssertCall<List<string>>(repository.GetAmulets());
        }

        [Theory]
        [InlineData("1", "4")]
        public void GetAmuletsById(params string[] ids)
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
        public void GetEndpoints()
        {
            AssertCall<string[]>(repository.GetEndpoints());
        }

        [Fact]
        public void GetAllHeroes()
        {
            AssertCall<List<PvPHero>>(repository.GetAllHeroes());
        }

        [Fact]
        public void GetHeroes()
        {
            AssertCall<List<string>>(repository.GetHeroes());
        }

        [Theory]
        [InlineData("115C140F-C2F5-40EB-8EA2-C3773F2AE468", "B7EA9889-5F16-4636-9705-4FCAF8B39ECD")]
        public void GetHeroesById(params string[] ids)
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
        public void GetMatches()
        {
            AssertCall<List<string>>(repository.GetMatches());
        }

        [Theory]
        [InlineData("1-1", "2-1")]
        public void GetMatchesById(params string[] ids)
        {
            AssertCall<List<Match>>(repository.GetMatches(ids));
        }

        [Fact]
        public void GetObjectives()
        {
            AssertCall<List<string>>(repository.GetObjectives());
        }

        [Theory]
        [InlineData("1099-99")]
        public void GetObjective(string id)
        {
            AssertCall<WvWObjective>(repository.GetObjective(id));
        }

        [Theory]
        [InlineData("1099-99", "96-35")]
        public void GetObjectivesById(params string[] ids)
        {
            AssertCall<List<WvWObjective>>(repository.GetObjectives(ids));
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
        public void GetWvWAbilities()
        {
            AssertCall<List<int>>(repository.GetWvWAbilities());
        }

        [Theory]
        [InlineData("4", "24")]
        public void GetWvWAbilitiesByIds(params string[] ids)
        {
            AssertCall<List<WvWAbility>>(repository.GetWvWAbilities(ids));
        }

        [Fact]
        public void GetWvWRanks()
        {
            AssertCall<List<int>>(repository.GetWvWRanks());
        }

        [Theory]
        [InlineData("20", "21", "30", "105")]
        public void GetWvWRanksByIds(params string[] ids)
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
        public void GetWvWUpgrades()
        {
            AssertCall<List<int>>(repository.GetWvWUpgrades());
        }

        [Theory]
        [InlineData("15", "16", "17")]
        public void GetWvWUpgradesByIds(params string[] ids)
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
