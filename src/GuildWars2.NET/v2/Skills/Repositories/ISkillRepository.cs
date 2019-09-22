using System.Collections.Generic;
using System.Threading.Tasks;
using GuildWars2.NET.v2.Skills.Entities;

namespace GuildWars2.NET.v2.Skills.Repositories
{
    public interface ISkillRepository
    {
        Legend GetLegend(string id);
        Task<Legend> GetLegendAsync(string id);
        ICollection<string> GetLegendIds();
        Task<ICollection<string>> GetLegendIdsAsync();
        ICollection<Legend> GetLegends(params string[] ids);
        Task<ICollection<Legend>> GetLegendsAsync(params string[] ids);
        ICollection<string> GetSkillIds();
        Task<ICollection<string>> GetSkillIdsAsync();
        ICollection<Skill> GetSkills(params string[] ids);
        Task<ICollection<Skill>> GetSkillsAsync(params string[] ids);
    }
}