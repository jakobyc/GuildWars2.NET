using GuildWars2.NET.Core.v2.Account.Entities;
using GuildWars2.NET.Core.v2.Account.Repositories;
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
            AssertCall<AccountAchievement[]>(repository.GetAchievements());
        }

        [Fact]
        public void GetBankitems()
        {
            AssertCall<BankItem[]>(repository.GetBankItems());
        }

        [Fact]
        public void GetCompletedDailyDungeons()
        {
            AssertCall<string[]>(repository.GetCompletedDailyDungeons());
        }

        [Fact]
        public void GetCompletedRaids()
        {
            AssertCall<string[]>(repository.GetCompletedRaids());
        }

        [Fact]
        public void GetDyes()
        {
            AssertCall<string[]>(repository.GetDyes());
        }

        [Fact]
        public void GetFinishers()
        {
            AssertCall<Finisher[]>(repository.GetFinishers());
        }

        [Fact]
        public void GetGliders()
        {
            AssertCall<int[]>(repository.GetGliders());
        }

        [Fact]
        public void GetHomeCats()
        {
            AssertCall<Cat[]>(repository.GetHomeCats());
        }

        [Fact]
        public void GetHomeNodes()
        {
            AssertCall<string[]>(repository.GetHomeNodes());
        }

        [Fact]
        public void GetMailCarriers()
        {
            AssertCall<int[]>(repository.GetMailCarriers());
        }

        [Fact]
        public void GetMasteries()
        {
            AssertCall<Mastery[]>(repository.GetMasteries());
        }

        [Fact]
        public void GetMasteryPoints()
        {
            AssertCall<MasteryPoints>(repository.GetMasteryPoints());
        }

        [Fact]
        public void GetMaterials()
        {
            AssertCall<Material[]>(repository.GetMaterials());
        }

        [Fact]
        public void GetMiniatures()
        {
            AssertCall<string[]>(repository.GetMiniatures());
        }

        [Fact]
        public void GetOutfits()
        {
            AssertCall<string[]>(repository.GetOutfits());
        }

        [Fact]
        public void GetPvPHeroes()
        {
            AssertCall<int[]>(repository.GetPvPHeroes());
        }

        [Fact]
        public void GetRecipes()
        {
            AssertCall<string[]>(repository.GetRecipes());
        }

        [Fact]
        public void GetSharedInventoryItems()
        {
            AssertCall<SharedInventoryItem[]>(repository.GetSharedInventoryItems());
        }

        [Fact]
        public void GetSkins()
        {
            AssertCall<string[]>(repository.GetSkins());
        }

        [Fact]
        public void GetTitles()
        {
            AssertCall<string[]>(repository.GetTitles());
        }

        [Fact]
        public void GetWallet()
        {
            AssertCall<WalletCurrency[]>(repository.GetWallet());
        }
    }
}
