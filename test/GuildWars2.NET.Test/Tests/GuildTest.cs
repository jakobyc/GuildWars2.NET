using GuildWars2.NET.Test.Dependencies;
using GuildWars2.NET.v2.Guilds.Entities;
using GuildWars2.NET.v2.Guilds.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class GuildTest : ApiTest
    {
        private GuildRepository repository;

        public GuildTest(RepositoryFactory factory)
        {
            this.repository = factory.GetGuildRepository();
        }

        [Fact]
        public void GetBackgroundEmblemIds()
        {
            AssertIds<List<string>>(repository.GetBackgroundEmblemIds());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public void GetBackgroundEmblems(params string[] ids)
        {
            AssertCall<List<Emblem>>(repository.GetBackgroundEmblems(ids));
        }

        [Theory]
        [InlineData("21")]
        public void GetBackgroundEmblem(string id)
        {
            AssertCall<Emblem>(repository.GetBackgroundEmblem(id));
        }

        [Fact]
        public void GetForegroundEmblemsIds()
        {
            AssertIds<List<string>>(repository.GetForegroundEmblemIds());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public void GetForegroundEmblems(params string[] ids)
        {
            AssertCall<List<Emblem>>(repository.GetForegroundEmblems(ids));
        }

        [Theory]
        [InlineData("46")]
        public void GetForegroundEmblem(string id)
        {
            AssertCall<Emblem>(repository.GetForegroundEmblem(id));
        }

        [Theory]
        [InlineData("116E0C0E-0035-44A9-BB22-4AE3E23127E5")]
        public void GetGuild(string id)
        {
            AssertCall<Guild>(repository.GetGuild(id));
        }

        [Theory]
        [InlineData("Edit Conflict")]
        public void GetGuildId(string name)
        {
            AssertCall<string[]>(repository.GetGuildId(name));
        }

        [Fact]
        public void GetLogs()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildLog>>(repository.GetLogs(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public void GetLogsSince()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                var logs = repository.GetLogs(guildId, apiKey);
                if (logs != null && logs.Count > 0)
                {
                    AssertCall<List<GuildLog>>(repository.GetLogsSince(guildId, apiKey, logs.First().Id));
                }
                else
                {
                    Assert.True(false, "No logs found.");
                }
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public void GetMembers()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildMember>>(repository.GetMembers(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public void GetRanks()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildRank>>(repository.GetRanks(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public void GetStash()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildStash>>(repository.GetStash(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public void GetStorage()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildStorage>>(repository.GetStorage(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public void GetTeams()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildTeam>>(repository.GetTeams(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public void GetTreasury()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildTreasury>>(repository.GetTreasury(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public void GetUpgradeIdsByGuild()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<string>>(repository.GetUpgradeIds(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public void GetPermissionIds()
        {
            AssertIds<List<string>>(repository.GetPermissionIds());
        }

        [Fact]
        public void GetAllPermissions()
        {
            AssertCall<List<GuildPermission>>(repository.GetAllPermissions());
        }

        [Theory]
        [InlineData("ClaimableEditOptions", "EditBGM")]
        public void GetPermissions(params string[] ids)
        {
            AssertCall<List<GuildPermission>>(repository.GetPermissions(ids));
        }

        [Theory]
        [InlineData("ActivatePlaceables")]
        public void GetPermission(string id)
        {
            AssertCall<GuildPermission>(repository.GetPermission(id));
        }

        [Fact]
        public void GetUpgradeIds()
        {
            AssertIds<List<string>>(repository.GetUpgradeIds());
        }

        [Fact]
        public void GetAllUpgrades()
        {
            AssertCall<List<GuildUpgrade>>(repository.GetAllUpgrades());
        }

        [Theory]
        [InlineData("38", "43")]
        public void GetUpgrades(params string[] ids)
        {
            AssertCall<List<GuildUpgrade>>(repository.GetUpgrades(ids));
        }

        [Theory]
        [InlineData("44")]
        public void GetUpgrade(string id)
        {
            AssertCall<GuildUpgrade>(repository.GetUpgrade(id));
        }

        #region Async
        [Fact]
        public async Task GetBackgroundEmblemIdsAsyncAsync()
        {
            AssertIds<List<string>>(await repository.GetBackgroundEmblemIdsAsync());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public async Task GetBackgroundEmblemsAsync(params string[] ids)
        {
            AssertCall<List<Emblem>>(await repository.GetBackgroundEmblemsAsync(ids));
        }

        [Theory]
        [InlineData("21")]
        public async Task GetBackgroundEmblemAsync(string id)
        {
            AssertCall<Emblem>(await repository.GetBackgroundEmblemAsync(id));
        }

        [Fact]
        public async Task GetForegroundEmblemsIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetForegroundEmblemIdsAsync());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public async Task GetForegroundEmblemsAsync(params string[] ids)
        {
            AssertCall<List<Emblem>>(await repository.GetForegroundEmblemsAsync(ids));
        }

        [Theory]
        [InlineData("46")]
        public async Task GetForegroundEmblemAsync(string id)
        {
            AssertCall<Emblem>(await repository.GetForegroundEmblemAsync(id));
        }

        [Theory]
        [InlineData("116E0C0E-0035-44A9-BB22-4AE3E23127E5")]
        public async Task GetGuildAsync(string id)
        {
            AssertCall<Guild>(await repository.GetGuildAsync(id));
        }

        [Theory]
        [InlineData("Edit Conflict")]
        public async Task GetGuildIdAsync(string name)
        {
            AssertCall<string[]>(await repository.GetGuildIdAsync(name));
        }

        [Fact]
        public async Task GetLogsAsync()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildLog>>(await repository.GetLogsAsync(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public async Task GetLogsSinceAsync()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                var logs = await repository.GetLogsAsync(guildId, apiKey);
                if (logs != null && logs.Count > 0)
                {
                    AssertCall<List<GuildLog>>(await repository.GetLogsSinceAsync(guildId, apiKey, logs.First().Id));
                }
                else
                {
                    Assert.True(false, "No logs found.");
                }
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public async Task GetMembersAsync()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildMember>>(await repository.GetMembersAsync(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public async Task GetRanksAsync()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildRank>>(await repository.GetRanksAsync(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public async Task GetStashAsync()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildStash>>(await repository.GetStashAsync(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public async Task GetStorageAsync()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildStorage>>(await repository.GetStorageAsync(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public async Task GetTeamsAsync()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildTeam>>(await repository.GetTeamsAsync(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public async Task GetTreasuryAsync()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<GuildTreasury>>(await repository.GetTreasuryAsync(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public async Task GetUpgradeIdsByGuildAsync()
        {
            string guildId = Config.GetGuild();
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(guildId) && !string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<string>>(await repository.GetUpgradeIdsAsync(guildId, apiKey));
            }
            else
            {
                Assert.True(false, "No guild id or API key found in appsettings.test.json.");
            }
        }

        [Fact]
        public async Task GetPermissionIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetPermissionIdsAsync());
        }

        [Fact]
        public async Task GetAllPermissionsAsync()
        {
            AssertCall<List<GuildPermission>>(await repository.GetAllPermissionsAsync());
        }

        [Theory]
        [InlineData("ClaimableEditOptions", "EditBGM")]
        public async Task GetPermissionsAsync(params string[] ids)
        {
            AssertCall<List<GuildPermission>>(await repository.GetPermissionsAsync(ids));
        }

        [Theory]
        [InlineData("ActivatePlaceables")]
        public async Task GetPermissionAsync(string id)
        {
            AssertCall<GuildPermission>(await repository.GetPermissionAsync(id));
        }

        [Fact]
        public async Task GetUpgradeIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetUpgradeIdsAsync());
        }

        [Fact]
        public async Task GetAllUpgradesAsync()
        {
            AssertCall<List<GuildUpgrade>>(await repository.GetAllUpgradesAsync());
        }

        [Theory]
        [InlineData("38", "43")]
        public async Task GetUpgradesAsync(params string[] ids)
        {
            AssertCall<List<GuildUpgrade>>(await repository.GetUpgradesAsync(ids));
        }

        [Theory]
        [InlineData("44")]
        public async Task GetUpgradeAsync(string id)
        {
            AssertCall<GuildUpgrade>(await repository.GetUpgradeAsync(id));
        }
        #endregion
    }
}
