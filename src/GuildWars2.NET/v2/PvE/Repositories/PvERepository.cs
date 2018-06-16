using GuildWars2.NET.Core.Data;
using GuildWars2.NET.Core.v2.PvE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.Core.v2.PvE.Repositories
{
    public class PvERepository : GW2Repository
    {
        public PvERepository(string apiKey) : base(apiKey) { }

        public ICollection<string> GetBackstoryAnswers()
        {
            return Retrieve<ICollection<string>>(CreateEndpoint("backstory/answers"));
        }

        public BackstoryAnswer GetBackstoryAnswer(string id)
        {
            return Retrieve<BackstoryAnswer>(CreateEndpoint($"backstory/answers/{id}"));
        }

        public ICollection<BackstoryAnswer> GetBackstoryAnswers(params string[] ids)
        {
            ICollection<string> parameters = new List<string>();
            parameters.Add(ParameterBuilder.Build("ids", ids));

            return Retrieve<ICollection<BackstoryAnswer>>(CreateEndpoint("backstory/answers", parameters));
        }
    }
}
