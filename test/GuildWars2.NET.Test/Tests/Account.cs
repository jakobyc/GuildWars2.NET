using GuildWars2.NET.Core.v2.Account.Repositories;
using GuildWars2.NET.Test.Dependencies;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class Account : IClassFixture<RepositoryFactory>
    {
        private AccountRepository repository;

        public Account(RepositoryFactory factory)
        {
            this.repository = factory.GetAccountRepository();
        }

        [Fact]
        public void Get()
        {
            Assert.NotNull(repository);

            repository.GetAccountInfo();
        }
    }
}
