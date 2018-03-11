using GuildWars2.NET.Builders.Parameters;
using GuildWars2.NET.Data;
using GuildWars2.NET.Serialization.JSON;
using GuildWars2.NET.v2.Achievements.DTOs;
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
        public AchievementRepository(JsonDeserializer deserializer, JsonRetriever retriever) : base(deserializer, retriever) { }

        /// <summary>
        /// Retrieve achievement information for selected achievement IDs.
        /// </summary>
        /// <param name="ids">Array of achievement IDs</param>
        /// <returns></returns>
        public ICollection<Achievement> GetAchievements(params string[] ids)
        {
            string idParameter = ParameterBuilder.Build("ids", ids);

            return Retrieve<ICollection<Achievement>>(new Achievement(), string.Empty, idParameter);
        }

        public ICollection<Category> GetCategories()
        {
            int[] categoryIds = Retrieve<ICollection<int>>(new Category()).ToArray<int>();
            ICollection<Category> categories = new List<Category>();

            string idParameter = ParameterBuilder.Build("ids", categoryIds);

            if (categoryIds.Length > 0)
            {
                categories = Retrieve<ICollection<Category>>(new Category(), string.Empty, idParameter);
            }
            return categories;
        }
    }
}
