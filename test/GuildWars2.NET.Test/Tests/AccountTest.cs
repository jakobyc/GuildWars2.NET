using GuildWars2.NET.v2.Account.Entities;
using GuildWars2.NET.v2.Account.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Threading.Tasks;
using GuildWars2.NET.Data;

namespace GuildWars2.NET.Test.Tests
{
    public class AccountTest : ApiTest
    {
        private readonly IAccountRepository repository;

        public AccountTest()
        {
            this.repository = Client.Account;
        }

        [Fact]
        public void GetAccountInfo()
        {
            AssertCall<AccountInfo>(repository.GetAccountInfo());
        }

        [Fact]
        public void GetAchievement()
        {
            AssertCall<AccountAchievement>(repository.GetAchievement(1));
        }

        [Fact]
        public void GetAchievements()
        {
            AssertCall<List<AccountAchievement>>(repository.GetAchievements());
        }

        [Fact]
        public void GetBankitems()
        {
            AssertCall<List<BankItem>>(repository.GetBankItems());
        }

        [Fact]
        public void GetCompletedDailyDungeons()
        {
            AssertCall<List<string>>(repository.GetCompletedDailyDungeons());
        }

        [Fact]
        public void GetCompletedRaids()
        {
            AssertCall<List<string>>(repository.GetCompletedRaids());
        }

        [Fact]
        public void GetDyes()
        {
            AssertCall<List<string>>(repository.GetDyes());
        }

        [Fact]
        public void GetFinishers()
        {
            AssertCall<List<Finisher>>(repository.GetFinishers());
        }

        [Fact]
        public void GetGliders()
        {
            AssertCall<List<string>>(repository.GetGliders());
        }

        [Fact]
        public void GetHomeCats()
        {
            AssertCall<List<Cat>>(repository.GetHomeCats());
        }

        [Fact]
        public void GetHomeNodes()
        {
            AssertCall<List<string>>(repository.GetHomeNodes());
        }

        [Fact]
        public void GetMailCarriers()
        {
            AssertCall<List<string>>(repository.GetMailCarriers());
        }

        [Fact]
        public void GetMasteries()
        {
            AssertCall<List<Mastery>>(repository.GetMasteries());
        }

        [Fact]
        public void GetMasteryPoints()
        {
            AssertCall<MasteryPoints>(repository.GetMasteryPoints());
        }

        [Fact]
        public void GetMaterials()
        {
            AssertCall<List<Material>>(repository.GetMaterials());
        }

        [Fact]
        public void GetMiniatures()
        {
            AssertCall<List<string>>(repository.GetMiniatures());
        }

        [Fact]
        public void GetOutfits()
        {
            AssertCall<List<string>>(repository.GetOutfits());
        }

        [Fact]
        public void GetPvPGames()
        {
            AssertCall<List<PvPGame>>(repository.GetPvPGames());
        }

        [Fact]
        public void GetPvPHeroes()
        {
            AssertCall<List<string>>(repository.GetPvPHeroes());
        }

        [Fact]
        public void GetPvPStandings()
        {
            AssertCall<List<PvPStandings>>(repository.GetPvPStandings());
        }

        [Fact]
        public void GetPvPStats()
        {
            AssertCall<PvPStats>(repository.GetPvPStats());
        }

        [Fact]
        public void GetRecipes()
        {
            AssertCall<List<string>>(repository.GetRecipes());
        }

        [Fact]
        public void GetSharedInventoryItems()
        {
            AssertCall<List<SharedInventoryItem>>(repository.GetSharedInventoryItems());
        }

        [Fact]
        public void GetSkins()
        {
            AssertCall<List<string>>(repository.GetSkins());
        }

        [Fact]
        public void GetTitles()
        {
            AssertCall<List<string>>(repository.GetTitles());
        }

        [Fact]
        public void GetWallet()
        {
            AssertCall<List<WalletCurrency>>(repository.GetWallet());
        }

        #region Async
        [Fact]
        public async Task GetAccountInfoAsync()
        {
            AssertCall<AccountInfo>(await repository.GetAccountInfoAsync());
        }

        [Fact]
        public async Task GetAchievementAsync()
        {
            AssertCall<AccountAchievement>(await repository.GetAchievementAsync(1));
        }

        [Fact]
        public async Task GetAchievementsAsync()
        {
            AssertCall<List<AccountAchievement>>(await repository.GetAchievementsAsync());
        }

        [Fact]
        public async Task GetBankitemsAsync()
        {
            AssertCall<List<BankItem>>(await repository.GetBankItemsAsync());
        }

        [Fact]
        public async Task GetCompletedDailyDungeonsAsync()
        {
            AssertCall<List<string>>(await repository.GetCompletedDailyDungeonsAsync());
        }

        [Fact]
        public async Task GetCompletedRaidsAsync()
        {
            AssertCall<List<string>>(await repository.GetCompletedRaidsAsync());
        }

        [Fact]
        public async Task GetDyesAsync()
        {
            AssertCall<List<string>>(await repository.GetDyesAsync());
        }

        [Fact]
        public async Task GetFinishersAsync()
        {
            AssertCall<List<Finisher>>(await repository.GetFinishersAsync());
        }

        [Fact]
        public async Task GetGlidersAsync()
        {
            AssertCall<List<string>>(await repository.GetGlidersAsync());
        }

        [Fact]
        public async Task GetHomeCatsAsync()
        {
            AssertCall<List<Cat>>(await repository.GetHomeCatsAsync());
        }

        [Fact]
        public async Task GetHomeNodesAsync()
        {
            AssertCall<List<string>>(await repository.GetHomeNodesAsync());
        }

        [Fact]
        public async Task GetMailCarriersAsync()
        {
            AssertCall<List<string>>(await repository.GetMailCarriersAsync());
        }

        [Fact]
        public async Task GetMasteriesAsync()
        {
            AssertCall<List<Mastery>>(await repository.GetMasteriesAsync());
        }

        [Fact]
        public async Task GetMasteryPointsAsync()
        {
            AssertCall<MasteryPoints>(await repository.GetMasteryPointsAsync());
        }

        [Fact]
        public async Task GetMaterialsAsync()
        {
            AssertCall<List<Material>>(await repository.GetMaterialsAsync());
        }

        [Fact]
        public async Task GetMiniaturesAsync()
        {
            AssertCall<List<string>>(await repository.GetMiniaturesAsync());
        }

        [Fact]
        public async Task GetOutfitsAsync()
        {
            AssertCall<List<string>>(await repository.GetOutfitsAsync());
        }

        [Fact]
        public async Task GetPvPGamesAsync()
        {
            AssertCall<List<PvPGame>>(await repository.GetPvPGamesAsync());
        }

        [Fact]
        public async Task GetPvPHeroesAsync()
        {
            AssertCall<List<string>>(await repository.GetPvPHeroesAsync());
        }

        [Fact]
        public async Task GetPvPStandingsAsync()
        {
            AssertCall<List<PvPStandings>>(await repository.GetPvPStandingsAsync());
        }

        [Fact]
        public async Task GetPvPStatsAsync()
        {
            AssertCall<PvPStats>(await repository.GetPvPStatsAsync());
        }

        [Fact]
        public async Task GetRecipesAsync()
        {
            AssertCall<List<string>>(await repository.GetRecipesAsync());
        }

        [Fact]
        public async Task GetSharedInventoryItemsAsync()
        {
            AssertCall<List<SharedInventoryItem>>(await repository.GetSharedInventoryItemsAsync());
        }

        [Fact]
        public async Task GetSkinsAsync()
        {
            AssertCall<List<string>>(await repository.GetSkinsAsync());
        }

        [Fact]
        public async Task GetTitlesAsync()
        {
            AssertCall<List<string>>(await repository.GetTitlesAsync());
        }

        [Fact]
        public async Task GetWalletAsync()
        {
            AssertCall<List<WalletCurrency>>(await repository.GetWalletAsync());
        }
        #endregion
    }
}
