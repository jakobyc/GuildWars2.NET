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
            string idParameter = "ids=";
            for (int i = 0; i < ids.Length; i++)
            {
                // If the current index is not the last:
                if (i < ids.Length - 1)
                {
                    idParameter += ids[i] + ',';
                }
                // Else don't add a comma
                else
                {
                    idParameter += ids[i];
                }
            }
            return Retrieve<ICollection<Achievement>>(new Achievement(), string.Empty, idParameter);
        }
    }
}
