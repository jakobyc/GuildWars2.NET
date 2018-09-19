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
        public void GetAllIcons()
        {
            AssertCall<List<Icon>>(repository.GetAllIcons());
        }

        [Fact]
        public void GetIcons()
        {
            AssertCall<List<string>>(repository.GetIcons());
        }

        [Theory]
        [InlineData("map_complete", "map_dungeon", "ui_coin_gold")]
        public void GetIconsById(params string[] ids)
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
        public void GetQuaggans()
        {
            AssertCall<List<string>>(repository.GetQuaggans());
        }

        [Theory]
        [InlineData("404", "hat", "box")]
        public void GetQuaggansById(params string[] ids)
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
        public void GetTitles()
        {
            AssertCall<List<string>>(repository.GetTitles());
        }

        [Theory]
        [InlineData("40", "90")]
        public void GetTitlesById(params string[] ids)
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
