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
        public void Get()
        {
            Assert.NotNull(repository);

            AssertCall<AccountInfo>(repository.GetAccountInfo());
            AssertCall<AccountAchievement>(repository.GetAchievement(1));
            AssertCall<AccountAchievement[]>(repository.GetAchievements());
            AssertCall<BankItem[]>(repository.GetBankItems());
            AssertCall<string[]>(repository.GetCompletedDailyDungeons());
            AssertCall<string[]>(repository.GetCompletedRaids());
            AssertCall<string[]>(repository.GetDyes());
            AssertCall<Finisher[]>(repository.GetFinishers());
            AssertCall<int[]>(repository.GetGliders());
            AssertCall<Cat[]>(repository.GetHomeCats());
            AssertCall<string[]>(repository.GetHomeNodes());
            AssertCall<int[]>(repository.GetMailCarriers());
            AssertCall<Mastery[]>(repository.GetMasteries());
            AssertCall<MasteryPoints>(repository.GetMasteryPoints());
            AssertCall<Material[]>(repository.GetMaterials());
            AssertCall<string[]>(repository.GetMiniatures());
            AssertCall<string[]>(repository.GetOutfits());
            AssertCall<int[]>(repository.GetPvPHeroes());
            AssertCall<string[]>(repository.GetRecipes());
            AssertCall<SharedInventoryItem[]>(repository.GetSharedInventoryItems());
            AssertCall<string[]>(repository.GetSkins());
            AssertCall<string[]>(repository.GetTitles());
            AssertCall<WalletCurrency[]>(repository.GetWallet());
        }


    }
}
