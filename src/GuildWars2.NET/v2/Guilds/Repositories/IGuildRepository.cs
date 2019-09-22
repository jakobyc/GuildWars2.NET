using System.Collections.Generic;
using System.Threading.Tasks;
using GuildWars2.NET.v2.Guilds.Entities;

namespace GuildWars2.NET.v2.Guilds.Repositories
{
    public interface IGuildRepository
    {
        ICollection<GuildPermission> GetAllPermissions();
        Task<ICollection<GuildPermission>> GetAllPermissionsAsync();
        ICollection<GuildUpgrade> GetAllUpgrades();
        Task<ICollection<GuildUpgrade>> GetAllUpgradesAsync();
        Emblem GetBackgroundEmblem(string id);
        Task<Emblem> GetBackgroundEmblemAsync(string id);
        ICollection<string> GetBackgroundEmblemIds();
        Task<ICollection<string>> GetBackgroundEmblemIdsAsync();
        ICollection<Emblem> GetBackgroundEmblems(params string[] ids);
        Task<ICollection<Emblem>> GetBackgroundEmblemsAsync(params string[] ids);
        Emblem GetForegroundEmblem(string id);
        Task<Emblem> GetForegroundEmblemAsync(string id);
        ICollection<string> GetForegroundEmblemIds();
        Task<ICollection<string>> GetForegroundEmblemIdsAsync();
        ICollection<Emblem> GetForegroundEmblems(params string[] ids);
        Task<ICollection<Emblem>> GetForegroundEmblemsAsync(params string[] ids);
        Guild GetGuild(string id);
        Task<Guild> GetGuildAsync(string id);
        string[] GetGuildId(string name);
        Task<string[]> GetGuildIdAsync(string name);
        ICollection<GuildLog> GetLogs(string guildId, string apiKey);
        Task<ICollection<GuildLog>> GetLogsAsync(string guildId, string apiKey);
        ICollection<GuildLog> GetLogsSince(string guildId, string apiKey, string logId);
        Task<ICollection<GuildLog>> GetLogsSinceAsync(string guildId, string apiKey, string logId);
        ICollection<GuildMember> GetMembers(string guildId, string apiKey);
        Task<ICollection<GuildMember>> GetMembersAsync(string guildId, string apiKey);
        GuildPermission GetPermission(string id);
        Task<GuildPermission> GetPermissionAsync(string id);
        ICollection<string> GetPermissionIds();
        Task<ICollection<string>> GetPermissionIdsAsync();
        ICollection<GuildPermission> GetPermissions(params string[] ids);
        Task<ICollection<GuildPermission>> GetPermissionsAsync(params string[] ids);
        ICollection<GuildRank> GetRanks(string guildId, string apiKey);
        Task<ICollection<GuildRank>> GetRanksAsync(string guildId, string apiKey);
        ICollection<GuildStash> GetStash(string guildId, string apiKey);
        Task<ICollection<GuildStash>> GetStashAsync(string guildId, string apiKey);
        ICollection<GuildStorage> GetStorage(string guildId, string apiKey);
        Task<ICollection<GuildStorage>> GetStorageAsync(string guildId, string apiKey);
        ICollection<GuildTeam> GetTeams(string guildId, string apiKey);
        Task<ICollection<GuildTeam>> GetTeamsAsync(string guildId, string apiKey);
        ICollection<GuildTreasury> GetTreasury(string guildId, string apiKey);
        Task<ICollection<GuildTreasury>> GetTreasuryAsync(string guildId, string apiKey);
        GuildUpgrade GetUpgrade(string id);
        Task<GuildUpgrade> GetUpgradeAsync(string id);
        ICollection<string> GetUpgradeIds();
        ICollection<string> GetUpgradeIds(string guildId, string apiKey);
        Task<ICollection<string>> GetUpgradeIdsAsync();
        Task<ICollection<string>> GetUpgradeIdsAsync(string guildId, string apiKey);
        ICollection<GuildUpgrade> GetUpgrades(params string[] ids);
        Task<ICollection<GuildUpgrade>> GetUpgradesAsync(params string[] ids);
    }
}