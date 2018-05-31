using GuildWars2.NET.Core.v2.Account.Repositories;
using GuildWars2.NET.Test.Tests;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Dependencies
{
    public class RepositoryFactory
    {
        private Config config;

        public RepositoryFactory()
        {
            config = Config.Load();
        }

        public AccountRepository GetAccountRepository()
        {
            return new AccountRepository(config.ApiKey);
        }
    }
}
