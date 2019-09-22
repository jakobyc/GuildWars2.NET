using System.Collections.Generic;
using System.Threading.Tasks;
using GuildWars2.NET.v2.Characters.Entities;
using GuildWars2.NET.v2.Skills.Entities;

namespace GuildWars2.NET.v2.Characters.Repositories
{
    public interface ICharacterRepository
    {
        Backstory GetBackstory(string characterName);
        Task<Backstory> GetBackstoryAsync(string characterName);
        CoreInformation GetCoreInformation(string characterName);
        Task<CoreInformation> GetCoreInformationAsync(string characterName);
        CraftingInfo GetCraftingInformation(string characterName);
        Task<CraftingInfo> GetCraftingInformationAsync(string characterName);
        Equipment GetEquipment(string characterName);
        Task<Equipment> GetEquipmentAsync(string characterName);
        ICollection<string> GetHeroPoints(string characterName);
        Task<ICollection<string>> GetHeroPointsAsync(string characterName);
        Inventory GetInventory(string characterName);
        Task<Inventory> GetInventoryAsync(string characterName);
        CharacterOverview GetOverview(string characterName);
        Task<CharacterOverview> GetOverviewAsync(string characterName);
        CharacterRecipes GetRecipes(string characterName);
        Task<CharacterRecipes> GetRecipesAsync(string characterName);
        CharacterSAB GetSABInfo(string characterName);
        Task<CharacterSAB> GetSABInfoAsync(string characterName);
        ICollection<Skill> GetSkills(string characterName, SkillType type);
        Task<ICollection<Skill>> GetSkillsAsync(string characterName, SkillType type);
        CharacterSpecializations GetSpecializations(string characterName);
        Task<CharacterSpecializations> GetSpecializationsAsync(string characterName);
        Training GetTrainingProgress(string characterName);
        Task<Training> GetTrainingProgressAsync(string characterName);
    }
}