using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Core.Data;
using GuildWars2.NET.v2.PvP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.Core.v2.PvP.Repositories
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
