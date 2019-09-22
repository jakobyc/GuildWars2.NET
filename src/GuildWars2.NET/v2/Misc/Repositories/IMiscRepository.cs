using System.Collections.Generic;
using System.Threading.Tasks;
using GuildWars2.NET.v2.Misc.Entities;

namespace GuildWars2.NET.v2.Misc.Repositories
{
    public interface IMiscRepository
    {
        ICollection<Icon> GetAllIcons();
        Task<ICollection<Icon>> GetAllIconsAsync();
        Build GetBuild();
        Task<Build> GetBuildAsync();
        Icon GetIcon(string id);
        Task<Icon> GetIconAsync(string id);
        ICollection<string> GetIconIds();
        Task<ICollection<string>> GetIconIdsAsync();
        ICollection<Icon> GetIcons(params string[] ids);
        Task<ICollection<Icon>> GetIconsAsync(params string[] ids);
        QuagganIcon GetQuaggan(string id);
        Task<QuagganIcon> GetQuagganAsync(string id);
        ICollection<string> GetQuagganIds();
        Task<ICollection<string>> GetQuagganIdsAsync();
        ICollection<QuagganIcon> GetQuaggans(params string[] ids);
        Task<ICollection<QuagganIcon>> GetQuaggansAsync(params string[] ids);
        Title GetTitle(string id);
        Task<Title> GetTitleAsync(string id);
        ICollection<string> GetTitleIds();
        Task<ICollection<string>> GetTitleIdsAsync();
        ICollection<Title> GetTitles(params string[] ids);
        Task<ICollection<Title>> GetTitlesAsync(params string[] ids);
        TokenInfo GetTokenInfo(string apiKey);
        Task<TokenInfo> GetTokenInfoAsync(string apiKey);
    }
}