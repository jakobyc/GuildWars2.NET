using GuildWars2.NET.Core.v2.PvP.Repositories;
using GuildWars2.NET.Test.Dependencies;
using GuildWars2.NET.v2.PvP.Entities;
using System;
using System.Collections.Generic;
using System.Text;
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
        public void GetMatches()
        {
            AssertCall<string[]>(repository.GetMatches());
        }

        [Theory]
        [InlineData("1-1", "2-1")]
        public void GetMatchesById(params string[] ids)
        {
            AssertCall<Match[]>(repository.GetMatches(ids));
        }

        [Fact]
        public void GetObjectives()
        {
            AssertCall<string[]>(repository.GetObjectives());
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
            AssertCall<WvWObjective[]>(repository.GetObjectives(ids));
        }

        [Theory]
        [InlineData("1-1", WvWTeam.Red)]
        public void GetTopGuildKDR(string matchId, WvWTeam team)
        {
            AssertCall<GuildStats[]>(repository.GetTopGuildKDR(matchId, team));
        }

        [Theory]
        [InlineData("1-1", WvWTeam.Red)]
        public void GetTopGuildKills(string matchId, WvWTeam team)
        {
            AssertCall<GuildStats[]>(repository.GetTopGuildKills(matchId, team));
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
            AssertCall<int[]>(repository.GetWvWAbilities());
        }

        [Theory]
        [InlineData("4", "24")]
        public void GetWvWAbilitiesByIds(params string[] ids)
        {
            AssertCall<WvWAbility[]>(repository.GetWvWAbilities(ids));
        }
    }
}
