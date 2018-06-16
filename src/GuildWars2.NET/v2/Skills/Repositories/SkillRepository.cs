using GuildWars2.NET.Core.Data;
using GuildWars2.NET.Core.Serialization.JSON;
using GuildWars2.NET.Core.v2.Skills.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.Core.v2.Skills.Repositories
{
    public class SkillRepository : GW2Repository
    {
        public SkillRepository(string apiKey) : base(apiKey) { }
        public SkillRepository(string apiKey, JsonDeserializer deserializer, JsonRetriever retriever) : base(apiKey, deserializer, retriever) { }

        public ICollection<int> GetAllSkills()
        {
            return Retrieve<ICollection<int>>(CreateEndpoint("skills"));
        }

        public ICollection<Skill> GetSkills(params string[] ids)
        {
            ICollection<string> parameters = new List<string>();
            parameters.Add(ParameterBuilder.Build("ids", ids));

            return Retrieve<ICollection<Skill>>(CreateEndpoint("skills", parameters));
        }
    }
}
