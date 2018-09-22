using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
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

        public ICollection<string> GetSkillIds()
        {
            return Retrieve<ICollection<string>>("skills");
        }

        public ICollection<string> GetLegendIds()
        {
            return Retrieve<ICollection<string>>("legends");
        }

        public ICollection<Legend> GetLegends(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("legends")
                                                            .AddParameter("ids", ids);

            return Retrieve<ICollection<Legend>>(builder);
        }

        public Legend GetLegend(string id)
        {
            return Retrieve<Legend>($"legends/{id}");
        }

        public ICollection<Skill> GetSkills(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("skills")
                                                            .AddParameter("ids", ids);

            return Retrieve<ICollection<Skill>>(builder);
        }

        #region Async
        public async Task<ICollection<string>> GetSkillIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("skills");
        }

        public async Task<ICollection<string>> GetLegendIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("legends");
        }

        public async Task<ICollection<Legend>> GetLegendsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("legends")
                                                            .AddParameter("ids", ids);

            return await RetrieveAsync<ICollection<Legend>>(builder);
        }

        public async Task<Legend> GetLegendAsync(string id)
        {
            return await RetrieveAsync<Legend>($"legends/{id}");
        }

        public async Task<ICollection<Skill>> GetSkillsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("skills")
                                                            .AddParameter("ids", ids);

            return await RetrieveAsync<ICollection<Skill>>(builder);
        }
        #endregion
    }
}
