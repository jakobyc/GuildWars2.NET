using System.Collections.Generic;
using System.Threading.Tasks;
using GuildWars2.NET.v2.Account.Entities;

namespace GuildWars2.NET.v2.Account.Repositories
{
    public interface IAccountRepository
    {
        AccountInfo GetAccountInfo();
        Task<AccountInfo> GetAccountInfoAsync();
        AccountAchievement GetAchievement(int id);
        Task<AccountAchievement> GetAchievementAsync(int id);
        ICollection<AccountAchievement> GetAchievements();
        Task<ICollection<AccountAchievement>> GetAchievementsAsync();
        ICollection<BankItem> GetBankItems();
        Task<ICollection<BankItem>> GetBankItemsAsync();
        ICollection<string> GetCompletedDailyDungeons();
        Task<ICollection<string>> GetCompletedDailyDungeonsAsync();
        ICollection<string> GetCompletedRaids();
        Task<ICollection<string>> GetCompletedRaidsAsync();
        ICollection<string> GetDyes();
        Task<ICollection<string>> GetDyesAsync();
        ICollection<Finisher> GetFinishers();
        Task<ICollection<Finisher>> GetFinishersAsync();
        ICollection<string> GetGliders();
        Task<ICollection<string>> GetGlidersAsync();
        ICollection<Cat> GetHomeCats();
        Task<ICollection<Cat>> GetHomeCatsAsync();
        ICollection<string> GetHomeNodes();
        Task<ICollection<string>> GetHomeNodesAsync();
        ICollection<string> GetMailCarriers();
        Task<ICollection<string>> GetMailCarriersAsync();
        ICollection<Mastery> GetMasteries();
        Task<ICollection<Mastery>> GetMasteriesAsync();
        MasteryPoints GetMasteryPoints();
        Task<MasteryPoints> GetMasteryPointsAsync();
        ICollection<Material> GetMaterials();
        Task<ICollection<Material>> GetMaterialsAsync();
        ICollection<string> GetMiniatures();
        Task<ICollection<string>> GetMiniaturesAsync();
        ICollection<string> GetOutfits();
        Task<ICollection<string>> GetOutfitsAsync();
        ICollection<PvPGame> GetPvPGames();
        Task<ICollection<PvPGame>> GetPvPGamesAsync();
        ICollection<string> GetPvPHeroes();
        Task<ICollection<string>> GetPvPHeroesAsync();
        ICollection<PvPStandings> GetPvPStandings();
        Task<ICollection<PvPStandings>> GetPvPStandingsAsync();
        PvPStats GetPvPStats();
        Task<PvPStats> GetPvPStatsAsync();
        ICollection<string> GetRecipes();
        Task<ICollection<string>> GetRecipesAsync();
        ICollection<SharedInventoryItem> GetSharedInventoryItems();
        Task<ICollection<SharedInventoryItem>> GetSharedInventoryItemsAsync();
        ICollection<string> GetSkins();
        Task<ICollection<string>> GetSkinsAsync();
        ICollection<string> GetTitles();
        Task<ICollection<string>> GetTitlesAsync();
        ICollection<WalletCurrency> GetWallet();
        Task<ICollection<WalletCurrency>> GetWalletAsync();
    }
}