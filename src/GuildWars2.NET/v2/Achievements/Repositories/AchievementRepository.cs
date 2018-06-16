using GuildWars2.NET.Core.Data;
using GuildWars2.NET.Core.Serialization.JSON;
using GuildWars2.NET.Core.v2.Achievements.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.Core.v2.Achievements.Repositories
{
    public class AchievementRepository : GW2Repository
    {
        public AchievementRepository(string apiKey) : base(apiKey) { }
        public AchievementRepository(string apiKey, JsonDeserializer deserializer, JsonRetriever retriever) : base(apiKey, deserializer, retriever) { }

        /// <summary>
        /// Get all achievement ids.
        /// </summary>
        public ICollection<int> GetAchievements()
        {
            return Retrieve<ICollection<int>>(CreateEndpoint($"achievements"));
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
                ICollection<string> parameters = new List<string>();
                parameters.Add(ParameterBuilder.Build("ids", ids));

                return Retrieve<ICollection<Achievement>>(CreateEndpoint($"achievements", parameters));
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
            return Retrieve<Category>(CreateEndpoint($"achievements/categories/{id}"));
        }

        /// <summary>
        /// Get all achievement categories.
        /// </summary>
        public ICollection<Category> GetCategories()
        {
            int[] categoryIds = Retrieve<ICollection<int>>(CreateEndpoint($"achievements/categories")).ToArray<int>();
            ICollection<Category> categories = new List<Category>();

            ICollection<string> parameters = new List<string>();
            parameters.Add(ParameterBuilder.Build("ids", categoryIds));

            if (categoryIds.Length > 0)
            {
                categories = Retrieve<ICollection<Category>>(CreateEndpoint($"achievements/categories", parameters));
            }
            return categories;
        }
        /// <summary>
        /// Get the dailies for today.
        /// </summary>
        public Dailies GetDailies()
        {
            return Retrieve<Dailies>(CreateEndpoint($"achievements/daily"));
        }

        /// <summary>
        /// Get the dailies for tomorrow.
        /// </summary>
        public Dailies GetTomorrowsDailies()
        {
            return Retrieve<Dailies>(CreateEndpoint($"achievements/daily/tomorrow"));
        }
    }
}
