using GuildWars2.NET.v2.Account.Entities;
using GuildWars2.NET.v2.Account.Repositories;
using GuildWars2.NET.Test.Dependencies;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class AccountTest : ApiTest
    {
        private AccountRepository repository;

        public AccountTest(RepositoryFactory factory)
        {
            this.repository = factory.GetAccountRepository();
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
            AssertCall<List<int>>(repository.GetGliders());
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
            AssertCall<List<int>>(repository.GetMailCarriers());
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
            AssertCall<List<int>>(repository.GetPvPHeroes());
        }

        [Fact]
        public void GetPvPStandings()
        {
            AssertCall<List<PvPStandings>>(repository.GetPvPStandings());
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
    }
}
