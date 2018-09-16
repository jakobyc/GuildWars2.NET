using GuildWars2.NET.Test.Dependencies;
using GuildWars2.NET.v2.Misc.Repositories;
using GuildWars2.NET.v2.PvP.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class MiscTest : ApiTest
    {
        private MiscRepository repository;

        public MiscTest(RepositoryFactory factory)
        {
            this.repository = factory.GetMiscRepository();
        }

        [Fact]
        public void GetTokenInfo()
        {
            AssertCall<TokenInfo>(repository.GetTokenInfo(Config.GetApiKey()));
        }
    }
}
