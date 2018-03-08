using GuildWars2.NET.Data;
using GuildWars2.NET.Serialization.JSON;
using GuildWars2.NET.v2.Skills.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Skills.Repositories
{
    public class SkillRepository : GW2Repository
    {
        public SkillRepository() : base() { }
        public SkillRepository(JsonDeserializer deserializer, JsonRetriever retriever) : base(deserializer, retriever) { }

        public v2.Skills.DTOs.Skills GetSkills(string accessToken, params string[] ids)
        {
            // TODO: Make a cleaner, reusable solution (parameter builder, etc.):
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
            return Retrieve<v2.Skills.DTOs.Skills>(new v2.Skills.DTOs.Skills(), accessToken, idParameter);
        }
    }
}
