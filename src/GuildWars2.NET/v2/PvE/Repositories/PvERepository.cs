using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Core.Data;
using GuildWars2.NET.Core.v2.PvE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.Core.v2.PvE.Repositories
{
    public class PvERepository : GW2Repository
    {
        public PvERepository() : base() { }

        public ICollection<string> GetBackstoryAnswers()
        {
            return Retrieve<ICollection<string>>("backstory/answers");
        }

        public BackstoryAnswer GetBackstoryAnswer(string id)
        {
            return Retrieve<BackstoryAnswer>($"backstory/answers/{id}");
        }

        public ICollection<BackstoryAnswer> GetBackstoryAnswers(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("backstory/answers")
                                                            .AddParameter("ids", ids);

            /*ICollection<string> parameters = new List<string>();
            parameters.Add(ParameterBuilder.Build("ids", ids));*/

            return Retrieve<ICollection<BackstoryAnswer>>(builder);
        }
    }
}
