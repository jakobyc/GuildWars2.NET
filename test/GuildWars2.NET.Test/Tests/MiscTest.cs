using GuildWars2.NET.Test.Dependencies;
using GuildWars2.NET.v2.Misc.Entities;
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
        public void GetBuild()
        {
            AssertCall<Build>(repository.GetBuild());
        }

        [Fact]
        public void GetAllIcons()
        {
            AssertCall<List<Icon>>(repository.GetAllIcons());
        }

        [Fact]
        public void GetIconIds()
        {
            AssertIds<List<string>>(repository.GetIconIds());
        }

        [Theory]
        [InlineData("map_complete", "map_dungeon", "ui_coin_gold")]
        public void GetIcons(params string[] ids)
        {
            AssertCall<List<Icon>>(repository.GetIcons(ids));
        }

        [Theory]
        [InlineData("ui_gem")]
        public void GetIcon(string id)
        {
            AssertCall<Icon>(repository.GetIcon(id));
        }

        [Fact]
        public void GetQuagganIds()
        {
            AssertIds<List<string>>(repository.GetQuagganIds());
        }

        [Theory]
        [InlineData("404", "hat", "box")]
        public void GetQuaggans(params string[] ids)
        {
            AssertCall<List<QuagganIcon>>(repository.GetQuaggans(ids));
        }

        [Theory]
        [InlineData("404")]
        public void GetQuaggan(string id)
        {
            AssertCall<QuagganIcon>(repository.GetQuaggan(id));
        }

        [Fact]
        public void GetTitleIds()
        {
            AssertIds<List<string>>(repository.GetTitleIds());
        }

        [Theory]
        [InlineData("40", "90")]
        public void GetTitles(params string[] ids)
        {
            AssertCall<List<Title>>(repository.GetTitles(ids));
        }

        [Theory]
        [InlineData("30")]
        public void GetTitle(string id)
        {
            AssertCall<Title>(repository.GetTitle(id));
        }

        [Fact]
        public void GetTokenInfo()
        {
            AssertCall<TokenInfo>(repository.GetTokenInfo(Config.GetApiKey()));
        }
    }
}
