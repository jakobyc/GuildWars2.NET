using GuildWars2.NET.Test.Dependencies;
using GuildWars2.NET.v2.Misc.Entities;
using GuildWars2.NET.v2.Misc.Repositories;
using GuildWars2.NET.v2.PvP.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class MiscTest : ApiTest
    {
        private readonly MiscRepository repository;

        public MiscTest()
        {
            this.repository = Client.Misc;
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

        #region Async
        [Fact]
        public async Task GetBuildAsync()
        {
            AssertCall<Build>(await repository.GetBuildAsync());
        }

        [Fact]
        public async Task GetAllIconsAsync()
        {
            AssertCall<List<Icon>>(await repository.GetAllIconsAsync());
        }

        [Fact]
        public async Task GetIconIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetIconIdsAsync());
        }

        [Theory]
        [InlineData("map_complete", "map_dungeon", "ui_coin_gold")]
        public async Task GetIconsAsync(params string[] ids)
        {
            AssertCall<List<Icon>>(await repository.GetIconsAsync(ids));
        }

        [Theory]
        [InlineData("ui_gem")]
        public async Task GetIconAsyncAsync(string id)
        {
            AssertCall<Icon>(await repository.GetIconAsync(id));
        }

        [Fact]
        public async Task GetQuagganIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetQuagganIdsAsync());
        }

        [Theory]
        [InlineData("404", "hat", "box")]
        public async Task GetQuaggansAsync(params string[] ids)
        {
            AssertCall<List<QuagganIcon>>(await repository.GetQuaggansAsync(ids));
        }

        [Theory]
        [InlineData("404")]
        public async Task GetQuagganAsync(string id)
        {
            AssertCall<QuagganIcon>(await repository.GetQuagganAsync(id));
        }

        [Fact]
        public async Task GetTitleIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetTitleIdsAsync());
        }

        [Theory]
        [InlineData("40", "90")]
        public async Task GetTitlesAsync(params string[] ids)
        {
            AssertCall<List<Title>>(await repository.GetTitlesAsync(ids));
        }

        [Theory]
        [InlineData("30")]
        public async Task GetTitleAsync(string id)
        {
            AssertCall<Title>(await repository.GetTitleAsync(id));
        }

        [Fact]
        public async Task GetTokenInfoAsync()
        {
            AssertCall<TokenInfo>(await repository.GetTokenInfoAsync(Config.GetApiKey()));
        }
        #endregion
    }
}
