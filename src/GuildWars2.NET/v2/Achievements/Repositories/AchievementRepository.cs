using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.Serialization.JSON;
using GuildWars2.NET.v2.Achievements.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Achievements.Repositories
{
    public class AchievementRepository : GW2Repository
    {
        public AchievementRepository() : base() { }

        /// <summary>
        /// Get all achievement ids.
        /// </summary>
        public ICollection<string> GetAchievements()
        {
            return Retrieve<ICollection<string>>($"achievements");
        }

        /// <summary>
        /// Retrieve achievement information for selected achievement IDs.
        /// </summary>
        /// <param name="ids">Array of achievement IDs</param>
        /// <returns></returns>
        public ICollection<Achievement> GetAchievements(params string[] ids)
        {
            if (ids.Length > 0)
            {
                IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("achievements")
                                                                .AddParameter("ids", ids);

                return Retrieve<ICollection<Achievement>>(builder);
            }
            else
            {
                return new List<Achievement>();
            }

        }

        /// <summary>
        /// Get a specific achievement category.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Category GetCategory(string id)
        {
            return Retrieve<Category>($"achievements/categories/{id}");
        }

        /// <summary>
        /// Get all achievement categories.
        /// </summary>
        public ICollection<Category> GetCategories()
        {
            string[] categoryIds = Retrieve<ICollection<string>>($"achievements/categories").ToArray();
            ICollection<Category> categories = new List<Category>();

            if (categoryIds.Length > 0)
            {
                IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("achievements")
                                                                .AddParameter("ids", categoryIds);

                categories = Retrieve<ICollection<Category>>(builder);
            }
            return categories;
        }
        /// <summary>
        /// Get the dailies for today.
        /// </summary>
        public Dailies GetDailies()
        {
            return Retrieve<Dailies>($"achievements/daily");
        }

        /// <summary>
        /// Get the dailies for tomorrow.
        /// </summary>
        public Dailies GetTomorrowsDailies()
        {
            return Retrieve<Dailies>($"achievements/daily/tomorrow");
        }
    }
}
