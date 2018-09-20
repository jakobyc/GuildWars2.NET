using GuildWars2.NET.Test.Dependencies;
using GuildWars2.NET.v2.Guilds.Entities;
using GuildWars2.NET.v2.Guilds.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void GetBackgroundEmblems()
        {
            AssertCall<List<string>>(repository.GetBackgroundEmblems());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public void GetBackgroundEmblemsById(params string[] ids)
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
        public void GetForegroundEmblems()
        {
            AssertCall<List<string>>(repository.GetForegroundEmblems());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public void GetForegroundEmblemsById(params string[] ids)
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
    }
}
