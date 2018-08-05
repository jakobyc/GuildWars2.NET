using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Core.Data;
using GuildWars2.NET.v2.PvP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.Core.v2.PvP.Repositories
{
    public class PvPRepository : GW2Repository
    {
        public PvPRepository() : base() { }

        public ICollection<int> GetWvWAbilities()
        {
            return Retrieve<ICollection<int>>(CreateEndpoint("wvw/abilities"));
        }

        public ICollection<WvWAbility> GetWvWAbilities(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("wvw/abilities")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<WvWAbility>>(builder);
        }
    }
}
