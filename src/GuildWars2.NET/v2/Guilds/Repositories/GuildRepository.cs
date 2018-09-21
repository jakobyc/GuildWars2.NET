using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.v2.Guilds.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Guilds.Repositories
{
    public class GuildRepository : GW2Repository
    {
        public GuildRepository() : base() { }

        public ICollection<string> GetBackgroundEmblems()
        {
            return Retrieve<ICollection<string>>("emblem/backgrounds");
        }

        public ICollection<Emblem> GetBackgroundEmblems(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("emblem/backgrounds")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Emblem>>(builder);
        }

        public Emblem GetBackgroundEmblem(string id)
        {
            return Retrieve<Emblem>($"emblem/backgrounds/{id}");
        }

        public ICollection<string> GetForegroundEmblems()
        {
            return Retrieve<ICollection<string>>("emblem/foregrounds");
        }

        public ICollection<Emblem> GetForegroundEmblems(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("emblem/foregrounds")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Emblem>>(builder);
        }

        public Emblem GetForegroundEmblem(string id)
        {
            return Retrieve<Emblem>($"emblem/foregrounds/{id}");
        }

        public Guild GetGuild(string id)
        {
            return Retrieve<Guild>($"guild/{id}");
        }

        public string[] GetGuildId(string name)
        {
            return Retrieve<string[]>($"guild/search?name={name}");
        }

        /// <summary>
        /// Get guild logs of a guild if the account of the api key is a guild leader.
        /// </summary>
        public ICollection<GuildLog> GetLogs(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/log")
                                                            .AddParameter("access_token", apiKey);
            return Retrieve<ICollection<GuildLog>>(builder);
        }

        /// <summary>
        /// Get guild logs of a guild if the account of the api key is a guild leader, since a certain log ID.
        /// </summary>
        public ICollection<GuildLog> GetLogsSince(string guildId, string apiKey, string logId)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/log")
                                                            .AddParameter("since", logId)
                                                            .AddParameter("access_token", apiKey);
            return Retrieve<ICollection<GuildLog>>(builder);
        }

        public ICollection<GuildMember> GetMembers(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/members")
                                                            .AddParameter("access_token", apiKey);
            return Retrieve<ICollection<GuildMember>>(builder);
        }

        public ICollection<GuildRank> GetRanks(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/ranks")
                                                            .AddParameter("access_token", apiKey);
            return Retrieve<ICollection<GuildRank>>(builder);
        }

        public ICollection<GuildStash> GetStash(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/stash")
                                                            .AddParameter("access_token", apiKey);
            return Retrieve<ICollection<GuildStash>>(builder);
        }

        public ICollection<GuildStorage> GetStorage(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/storage")
                                                            .AddParameter("access_token", apiKey);
            return Retrieve<ICollection<GuildStorage>>(builder);
        }

        public ICollection<GuildTeam> GetTeams(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/teams")
                                                            .AddParameter("access_token", apiKey);
            return Retrieve<ICollection<GuildTeam>>(builder);
        }

        public ICollection<GuildTreasury> GetTreasury(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/treasury")
                                                            .AddParameter("access_token", apiKey);
            return Retrieve<ICollection<GuildTreasury>>(builder);
        }
    }
}
