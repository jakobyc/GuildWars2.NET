using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.v2.Misc.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Misc.Repositories
{
    public class MiscRepository : GW2Repository
    {
        public MiscRepository() : base() { }

        public ICollection<string> GetQuaggans()
        {
            return Retrieve<ICollection<string>>("quaggans");
        }

        public ICollection<QuagganIcon> GetQuaggans(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("quaggans")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<QuagganIcon>>(builder);
        }

        public QuagganIcon GetQuaggan(string id)
        {
            return Retrieve<QuagganIcon>($"quaggans/{id}");
        }

        public ICollection<string>GetTitles()
        {
            return Retrieve<ICollection<string>>("titles");
        }

        public ICollection<Title> GetTitles(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("titles")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Title>>(builder);
        }

        public Title GetTitle(string id)
        {
            return Retrieve<Title>($"titles/{id}");
        }

        public TokenInfo GetTokenInfo(string apiKey)
        {
            return Retrieve<TokenInfo>($"tokeninfo?access_token={apiKey}");
        }
    }
}
