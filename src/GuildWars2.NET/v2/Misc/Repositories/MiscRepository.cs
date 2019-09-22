using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.v2.Misc.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Misc.Repositories
{
    internal class MiscRepository : GW2Repository, IMiscRepository
    {
        public MiscRepository() : base() { }

        public Build GetBuild()
        {
            return Retrieve<Build>("build");
        }

        public ICollection<Icon> GetAllIcons()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("files")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<Icon>>(builder);
        }

        public ICollection<string> GetIconIds()
        {
            return Retrieve<ICollection<string>>("files");
        }

        public ICollection<Icon> GetIcons(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("files")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Icon>>(builder);
        }

        public Icon GetIcon(string id)
        {
            return Retrieve<Icon>($"files/{id}");
        }

        public ICollection<string> GetQuagganIds()
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

        public ICollection<string> GetTitleIds()
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

        #region Async
        public async Task<Build> GetBuildAsync()
        {
            return await RetrieveAsync<Build>("build");
        }

        public async Task<ICollection<Icon>> GetAllIconsAsync()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("files")
                                                            .AddParameter("ids", "all");
            return await RetrieveAsync<ICollection<Icon>>(builder);
        }

        public async Task<ICollection<string>> GetIconIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("files");
        }

        public async Task<ICollection<Icon>> GetIconsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("files")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Icon>>(builder);
        }

        public async Task<Icon> GetIconAsync(string id)
        {
            return await RetrieveAsync<Icon>($"files/{id}");
        }

        public async Task<ICollection<string>> GetQuagganIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("quaggans");
        }

        public async Task<ICollection<QuagganIcon>> GetQuaggansAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("quaggans")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<QuagganIcon>>(builder);
        }

        public async Task<QuagganIcon> GetQuagganAsync(string id)
        {
            return await RetrieveAsync<QuagganIcon>($"quaggans/{id}");
        }

        public async Task<ICollection<string>> GetTitleIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("titles");
        }

        public async Task<ICollection<Title>> GetTitlesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("titles")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Title>>(builder);
        }

        public async Task<Title> GetTitleAsync(string id)
        {
            return await RetrieveAsync<Title>($"titles/{id}");
        }

        public async Task<TokenInfo> GetTokenInfoAsync(string apiKey)
        {
            return await RetrieveAsync<TokenInfo>($"tokeninfo?access_token={apiKey}");
        }
        #endregion
    }
}
