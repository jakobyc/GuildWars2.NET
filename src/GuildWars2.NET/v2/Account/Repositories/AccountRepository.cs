using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuildWars2.NET.v2.Account.Entities;
using GuildWars2.NET.Serialization.JSON;
using GuildWars2.NET.Data;
using GuildWars2.NET.Builders.Endpoints;

namespace GuildWars2.NET.v2.Account.Repositories
{
    internal class AccountRepository : GW2Repository, IAccountRepository
    {
        public AccountRepository(string apiKey) : base(apiKey) { }
        public AccountRepository(string apiKey, JsonDeserializer deserializer, JsonRetriever retriever) : base(apiKey, deserializer, retriever) { }

        public AccountInfo GetAccountInfo()
        {
            return Retrieve<AccountInfo>("account");
        }

        public ICollection<AccountAchievement> GetAchievements()
        {
            return Retrieve<ICollection<AccountAchievement>>("account/achievements");
        }

        public AccountAchievement GetAchievement(int id)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("account/achievements")
                                                            .AddParameter("id", id);

            return Retrieve<AccountAchievement>(builder);
        }

        public ICollection<BankItem> GetBankItems()
        {
            return Retrieve<ICollection<BankItem>>("account/bank");
        }

        public ICollection<string> GetCompletedDailyDungeons()
        {
            return Retrieve<ICollection<string>>("account/dungeons");
        }

        public ICollection<string> GetDyes()
        {
            return Retrieve<ICollection<string>>("account/dyes");
        }

        public ICollection<Finisher> GetFinishers()
        {
            return Retrieve<ICollection<Finisher>>("account/finishers");
        }

        public ICollection<string> GetGliders()
        {
            return Retrieve<ICollection<string>>("account/gliders");
        }

        public ICollection<Cat> GetHomeCats()
        {
            return Retrieve<ICollection<Cat>>("account/home/cats");
        }

        public ICollection<string> GetHomeNodes()
        {
            return Retrieve<ICollection<string>>("account/home/nodes");
        }

        public ICollection<SharedInventoryItem> GetSharedInventoryItems()
        {
            return Retrieve<ICollection<SharedInventoryItem>>("account/inventory");
        }

        public ICollection<string> GetMailCarriers()
        {
            return Retrieve<ICollection<string>>("account/mailcarriers");
        }

        public ICollection<Mastery> GetMasteries()
        {
            return Retrieve<ICollection<Mastery>>("account/masteries");
        }

        public MasteryPoints GetMasteryPoints()
        {
            return Retrieve<MasteryPoints>("account/mastery/points");
        }

        public ICollection<Material> GetMaterials()
        {
            return Retrieve<ICollection<Material>>("account/materials");
        }

        public ICollection<string> GetMiniatures()
        {
            return Retrieve<ICollection<string>>("account/minis");
        }

        public ICollection<string> GetOutfits()
        {
            return Retrieve<ICollection<string>>("account/outfits");
        }

        public ICollection<PvPGame> GetPvPGames()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/games")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<PvPGame>>(builder);
        }

        public ICollection<string> GetPvPHeroes()
        {
            return Retrieve<ICollection<string>>("account/pvp/heroes");
        }

        public ICollection<PvPStandings> GetPvPStandings()
        {
            return Retrieve<ICollection<PvPStandings>>("pvp/standings");
        }

        public PvPStats GetPvPStats()
        {
            return Retrieve<PvPStats>("pvp/stats");
        }

        public ICollection<string> GetCompletedRaids()
        {
            return Retrieve<ICollection<string>>("account/raids");
        }

        public ICollection<string> GetRecipes()
        {
            return Retrieve<ICollection<string>>("account/recipes");
        }

        public ICollection<string> GetSkins()
        {
            return Retrieve<ICollection<string>>("account/skins");
        }

        public ICollection<string> GetTitles()
        {
            return Retrieve<ICollection<string>>("account/titles");
        }

        public ICollection<WalletCurrency> GetWallet()
        {
            return Retrieve<ICollection<WalletCurrency>>("account/wallet");
        }

        #region Async
        public async Task<AccountInfo> GetAccountInfoAsync()
        {
            return await RetrieveAsync<AccountInfo>("account");
        }

        public async Task<ICollection<AccountAchievement>> GetAchievementsAsync()
        {
            return await RetrieveAsync<ICollection<AccountAchievement>>("account/achievements");
        }

        public async Task<AccountAchievement> GetAchievementAsync(int id)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("account/achievements")
                                                            .AddParameter("id", id);

            return await RetrieveAsync<AccountAchievement>(builder);
        }

        public async Task<ICollection<BankItem>> GetBankItemsAsync()
        {
            return await RetrieveAsync<ICollection<BankItem>>("account/bank");
        }

        public async Task<ICollection<string>> GetCompletedDailyDungeonsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("account/dungeons");
        }

        public async Task<ICollection<string>> GetDyesAsync()
        {
            return await RetrieveAsync<ICollection<string>>("account/dyes");
        }

        public async Task<ICollection<Finisher>> GetFinishersAsync()
        {
            return await RetrieveAsync<ICollection<Finisher>>("account/finishers");
        }

        public async Task<ICollection<string>> GetGlidersAsync()
        {
            return await RetrieveAsync<ICollection<string>>("account/gliders");
        }

        public async Task<ICollection<Cat>> GetHomeCatsAsync()
        {
            return await RetrieveAsync<ICollection<Cat>>("account/home/cats");
        }

        public async Task<ICollection<string>> GetHomeNodesAsync()
        {
            return await RetrieveAsync<ICollection<string>>("account/home/nodes");
        }

        public async Task<ICollection<SharedInventoryItem>> GetSharedInventoryItemsAsync()
        {
            return await RetrieveAsync<ICollection<SharedInventoryItem>>("account/inventory");
        }

        public async Task<ICollection<string>> GetMailCarriersAsync()
        {
            return await RetrieveAsync<ICollection<string>>("account/mailcarriers");
        }

        public async Task<ICollection<Mastery>> GetMasteriesAsync()
        {
            return await RetrieveAsync<ICollection<Mastery>>("account/masteries");
        }

        public async Task<MasteryPoints> GetMasteryPointsAsync()
        {
            return await RetrieveAsync<MasteryPoints>("account/mastery/points");
        }

        public async Task<ICollection<Material>> GetMaterialsAsync()
        {
            return await RetrieveAsync<ICollection<Material>>("account/materials");
        }

        public async Task<ICollection<string>> GetMiniaturesAsync()
        {
            return await RetrieveAsync<ICollection<string>>("account/minis");
        }

        public async Task<ICollection<string>> GetOutfitsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("account/outfits");
        }

        public async Task<ICollection<PvPGame>> GetPvPGamesAsync()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/games")
                                                            .AddParameter("ids", "all");
            return await RetrieveAsync<ICollection<PvPGame>>(builder);
        }

        public async Task<ICollection<string>> GetPvPHeroesAsync()
        {
            return await RetrieveAsync<ICollection<string>>("account/pvp/heroes");
        }

        public async Task<ICollection<PvPStandings>> GetPvPStandingsAsync()
        {
            return await RetrieveAsync<ICollection<PvPStandings>>("pvp/standings");
        }

        public async Task<PvPStats> GetPvPStatsAsync()
        {
            return await RetrieveAsync<PvPStats>("pvp/stats");
        }

        public async Task<ICollection<string>> GetCompletedRaidsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("account/raids");
        }

        public async Task<ICollection<string>> GetRecipesAsync()
        {
            return await RetrieveAsync<ICollection<string>>("account/recipes");
        }

        public async Task<ICollection<string>> GetSkinsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("account/skins");
        }

        public async Task<ICollection<string>> GetTitlesAsync()
        {
            return await RetrieveAsync<ICollection<string>>("account/titles");
        }

        public async Task<ICollection<WalletCurrency>> GetWalletAsync()
        {
            return await RetrieveAsync<ICollection<WalletCurrency>>("account/wallet");
        }
        #endregion
    }
}
