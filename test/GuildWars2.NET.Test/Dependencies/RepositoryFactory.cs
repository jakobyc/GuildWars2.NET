using GuildWars2.NET.Core.v2.Account.Repositories;
using GuildWars2.NET.Core.v2.Achievements.Repositories;
using GuildWars2.NET.Test.Tests;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Dependencies
{
    public class RepositoryFactory
    {
        public RepositoryFactory() { }

        public AccountRepository GetAccountRepository()
        {
            return new AccountRepository(Config.Instance.ApiKey);
        }

        public AchievementRepository GetAchievementRepository()
        {
            return new AchievementRepository(Config.Instance.ApiKey);
        }
    }
}
