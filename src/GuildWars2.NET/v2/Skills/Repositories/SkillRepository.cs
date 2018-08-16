using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.Serialization.JSON;
using GuildWars2.NET.v2.Skills.Entities;
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

        public ICollection<int> GetAllSkills()
        {
            return Retrieve<ICollection<int>>("skills");
        }

        public ICollection<Skill> GetSkills(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("skills")
                                                            .AddParameter("ids", ids);

            return Retrieve<ICollection<Skill>>(builder);
        }
    }
}
