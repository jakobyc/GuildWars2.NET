using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.v2.Guilds.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Guilds.Repositories
{
    public class GuildRepository : GW2Repository
    {
        public GuildRepository() : base() { }

        public ICollection<string> GetBackgroundEmblemIds()
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

        public ICollection<string> GetForegroundEmblemIds()
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

        public ICollection<string> GetUpgradeIds(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/upgrades")
                                                            .AddParameter("access_token", apiKey);
            return Retrieve<ICollection<string>>(builder);
        }

        public ICollection<string> GetUpgradeIds()
        {
            return Retrieve<ICollection<string>>("guild/upgrades");
        }

        public ICollection<GuildUpgrade> GetAllUpgrades()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/upgrades")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<GuildUpgrade>>(builder);
        }

        public ICollection<GuildUpgrade> GetUpgrades(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/upgrades")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<GuildUpgrade>>(builder);
        }

        public GuildUpgrade GetUpgrade(string id)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/upgrades")
                                                            .AddParameter("id", id);
            return Retrieve<GuildUpgrade>(builder);
        }

        public ICollection<string> GetPermissionIds()
        {
            return Retrieve<ICollection<string>>("guild/permissions");
        }

        public ICollection<GuildPermission> GetAllPermissions()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/permissions")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<GuildPermission>>(builder);
        }

        public ICollection<GuildPermission> GetPermissions(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/permissions")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<GuildPermission>>(builder);
        }

        public GuildPermission GetPermission(string id)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/permissions")
                                                            .AddParameter("id", id);
            return Retrieve<GuildPermission>(builder);
        }

        #region Async
        public async Task<ICollection<string>> GetBackgroundEmblemIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("emblem/backgrounds");
        }

        public async Task<ICollection<Emblem>> GetBackgroundEmblemsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("emblem/backgrounds")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Emblem>>(builder);
        }

        public async Task<Emblem> GetBackgroundEmblemAsync(string id)
        {
            return await RetrieveAsync<Emblem>($"emblem/backgrounds/{id}");
        }

        public async Task<ICollection<string>> GetForegroundEmblemIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("emblem/foregrounds");
        }

        public async Task<ICollection<Emblem>> GetForegroundEmblemsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("emblem/foregrounds")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Emblem>>(builder);
        }

        public async Task<Emblem> GetForegroundEmblemAsync(string id)
        {
            return await RetrieveAsync<Emblem>($"emblem/foregrounds/{id}");
        }

        public async Task<Guild> GetGuildAsync(string id)
        {
            return await RetrieveAsync<Guild>($"guild/{id}");
        }

        public async Task<string[]> GetGuildIdAsync(string name)
        {
            return await RetrieveAsync<string[]>($"guild/search?name={name}");
        }

        /// <summary>
        /// Get guild logs of a guild if the account of the api key is a guild leader.
        /// </summary>
        public async Task<ICollection<GuildLog>> GetLogsAsync(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/log")
                                                            .AddParameter("access_token", apiKey);
            return await RetrieveAsync<ICollection<GuildLog>>(builder);
        }

        /// <summary>
        /// Get guild logs of a guild if the account of the api key is a guild leader, since a certain log ID.
        /// </summary>
        public async Task<ICollection<GuildLog>> GetLogsSinceAsync(string guildId, string apiKey, string logId)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/log")
                                                            .AddParameter("since", logId)
                                                            .AddParameter("access_token", apiKey);
            return await RetrieveAsync<ICollection<GuildLog>>(builder);
        }

        public async Task<ICollection<GuildMember>> GetMembersAsync(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/members")
                                                            .AddParameter("access_token", apiKey);
            return await RetrieveAsync<ICollection<GuildMember>>(builder);
        }

        public async Task<ICollection<GuildRank>> GetRanksAsync(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/ranks")
                                                            .AddParameter("access_token", apiKey);
            return await RetrieveAsync<ICollection<GuildRank>>(builder);
        }

        public async Task<ICollection<GuildStash>> GetStashAsync(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/stash")
                                                            .AddParameter("access_token", apiKey);
            return await RetrieveAsync<ICollection<GuildStash>>(builder);
        }

        public async Task<ICollection<GuildStorage>> GetStorageAsync(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/storage")
                                                            .AddParameter("access_token", apiKey);
            return await RetrieveAsync<ICollection<GuildStorage>>(builder);
        }

        public async Task<ICollection<GuildTeam>> GetTeamsAsync(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/teams")
                                                            .AddParameter("access_token", apiKey);
            return await RetrieveAsync<ICollection<GuildTeam>>(builder);
        }

        public async Task<ICollection<GuildTreasury>> GetTreasuryAsync(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/treasury")
                                                            .AddParameter("access_token", apiKey);
            return await RetrieveAsync<ICollection<GuildTreasury>>(builder);
        }

        public async Task<ICollection<string>> GetUpgradeIdsAsync(string guildId, string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/upgrades")
                                                            .AddParameter("access_token", apiKey);
            return await RetrieveAsync<ICollection<string>>(builder);
        }

        public async Task<ICollection<string>> GetUpgradeIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("guild/upgrades");
        }

        public async Task<ICollection<GuildUpgrade>> GetAllUpgradesAsync()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/upgrades")
                                                            .AddParameter("ids", "all");
            return await RetrieveAsync<ICollection<GuildUpgrade>>(builder);
        }

        public async Task<ICollection<GuildUpgrade>> GetUpgradesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/upgrades")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<GuildUpgrade>>(builder);
        }

        public async Task<GuildUpgrade> GetUpgradeAsync(string id)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/upgrades")
                                                            .AddParameter("id", id);
            return await RetrieveAsync<GuildUpgrade>(builder);
        }

        public async Task<ICollection<string>> GetPermissionIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("guild/permissions");
        }

        public async Task<ICollection<GuildPermission>> GetAllPermissionsAsync()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/permissions")
                                                            .AddParameter("ids", "all");
            return await RetrieveAsync<ICollection<GuildPermission>>(builder);
        }

        public async Task<ICollection<GuildPermission>> GetPermissionsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/permissions")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<GuildPermission>>(builder);
        }

        public async Task<GuildPermission> GetPermissionAsync(string id)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/permissions")
                                                            .AddParameter("id", id);
            return await RetrieveAsync<GuildPermission>(builder);
        }
        #endregion
    }
}
