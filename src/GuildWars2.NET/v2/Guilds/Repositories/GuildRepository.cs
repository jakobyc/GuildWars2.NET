using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.v2.Guilds.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Guilds.Repositories
{
    internal class GuildRepository : GW2Repository, IGuildRepository
    {
        public GuildRepository(string apiKey = null) : base(apiKey) { }

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
            return Retrieve<Guild>($"guild/{id}", new GW2RESTConfig() { IgnoreAuthentication = true });
        }

        public string[] GetGuildId(string name)
        {
            return Retrieve<string[]>($"guild/search?name={name}");
        }

        /// <summary>
        /// Get guild logs of a guild if the account of the api key is a guild leader.
        /// </summary>
        public ICollection<GuildLog> GetLogs(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/log");
            return Retrieve<ICollection<GuildLog>>(builder);
        }

        /// <summary>
        /// Get guild logs of a guild if the account of the api key is a guild leader, since a certain log ID.
        /// </summary>
        public ICollection<GuildLog> GetLogsSince(string guildId, string logId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/log")
                                                            .AddParameter("since", logId);
            return Retrieve<ICollection<GuildLog>>(builder);
        }

        public ICollection<GuildMember> GetMembers(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/members");
            return Retrieve<ICollection<GuildMember>>(builder);
        }

        public ICollection<GuildRank> GetRanks(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/ranks");
            return Retrieve<ICollection<GuildRank>>(builder);
        }

        public ICollection<GuildStash> GetStash(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/stash");
            return Retrieve<ICollection<GuildStash>>(builder);
        }

        public ICollection<GuildStorage> GetStorage(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/storage");
            return Retrieve<ICollection<GuildStorage>>(builder);
        }

        public ICollection<GuildTeam> GetTeams(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/teams");
            return Retrieve<ICollection<GuildTeam>>(builder);
        }

        public ICollection<GuildTreasury> GetTreasury(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/treasury");
            return Retrieve<ICollection<GuildTreasury>>(builder);
        }

        public ICollection<string> GetUpgradeIds(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/upgrades");
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
            return await RetrieveAsync<Guild>($"guild/{id}", new GW2RESTConfig() { IgnoreAuthentication = true });
        }

        public async Task<string[]> GetGuildIdAsync(string name)
        {
            return await RetrieveAsync<string[]>($"guild/search?name={name}");
        }

        /// <summary>
        /// Get guild logs of a guild if the account of the api key is a guild leader.
        /// </summary>
        public async Task<ICollection<GuildLog>> GetLogsAsync(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/log");
            return await RetrieveAsync<ICollection<GuildLog>>(builder);
        }

        /// <summary>
        /// Get guild logs of a guild if the account of the api key is a guild leader, since a certain log ID.
        /// </summary>
        public async Task<ICollection<GuildLog>> GetLogsSinceAsync(string guildId, string logId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/log")
                                                            .AddParameter("since", logId);
            return await RetrieveAsync<ICollection<GuildLog>>(builder);
        }

        public async Task<ICollection<GuildMember>> GetMembersAsync(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/members");
            return await RetrieveAsync<ICollection<GuildMember>>(builder);
        }

        public async Task<ICollection<GuildRank>> GetRanksAsync(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/ranks");
            return await RetrieveAsync<ICollection<GuildRank>>(builder);
        }

        public async Task<ICollection<GuildStash>> GetStashAsync(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/stash");
            return await RetrieveAsync<ICollection<GuildStash>>(builder);
        }

        public async Task<ICollection<GuildStorage>> GetStorageAsync(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/storage");
            return await RetrieveAsync<ICollection<GuildStorage>>(builder);
        }

        public async Task<ICollection<GuildTeam>> GetTeamsAsync(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/teams");
            return await RetrieveAsync<ICollection<GuildTeam>>(builder);
        }

        public async Task<ICollection<GuildTreasury>> GetTreasuryAsync(string guildId)
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/treasury");
            return await RetrieveAsync<ICollection<GuildTreasury>>(builder);
        }

        public async Task<ICollection<string>> GetUpgradeIdsAsync(string guildId)
        {
            ValidateToken();
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint($"guild/{guildId}/upgrades");
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
