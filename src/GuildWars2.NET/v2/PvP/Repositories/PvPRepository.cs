﻿using GuildWars2.NET.Builders.Endpoints;
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

        public ICollection<string> GetAmulets()
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

        public ICollection<string> GetHeroes()
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

        public Match GetMatch(string id)
        {
            return Retrieve<Match>($"wvw/matches/{id}");
        }

        public async Task<Match> GetMatchAsync(string id)
        {
            return await RetrieveAsync<Match>($"wvw/matches/{id}");
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

        public ICollection<string> GetMatches()
        {
            return Retrieve<ICollection<string>>("wvw/matches");
        }

        public ICollection<Match> GetMatches(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/matches")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Match>>(builder);
        }

        public ICollection<string> GetObjectives()
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

        public ICollection<string> GetPvPRanks()
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

        public ICollection<int> GetWvWAbilities()
        {
            return Retrieve<ICollection<int>>("wvw/abilities");
        }

        public ICollection<WvWAbility> GetWvWAbilities(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/abilities")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<WvWAbility>>(builder);
        }

        public ICollection<int> GetWvWRanks()
        {
            return Retrieve<ICollection<int>>("wvw/ranks");
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

        public ICollection<int> GetWvWUpgrades()
        {
            return Retrieve<ICollection<int>>("wvw/upgrades");
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
