using System.Collections.Generic;
using System.Threading.Tasks;
using GuildWars2.NET.v2.Achievements.Entities;

namespace GuildWars2.NET.v2.Achievements.Repositories
{
    public interface IAchievementRepository
    {
        ICollection<string> GetAchievements();
        ICollection<Achievement> GetAchievements(params string[] ids);
        Task<ICollection<string>> GetAchievementsAsync();
        Task<ICollection<Achievement>> GetAchievementsAsync(params string[] ids);
        ICollection<Category> GetCategories();
        Task<ICollection<Category>> GetCategoriesAsync();
        Category GetCategory(string id);
        Task<Category> GetCategoryAsync(string id);
        Dailies GetDailies();
        Task<Dailies> GetDailiesAsync();
        Dailies GetTomorrowsDailies();
        Task<Dailies> GetTomorrowsDailiesAsync();
    }
}