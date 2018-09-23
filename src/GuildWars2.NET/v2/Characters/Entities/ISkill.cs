using System.Collections.Generic;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public interface ISkill
    {
        string EliteId { get; set; }
        string HealId { get; set; }
        ICollection<string> UtilitiesIDs { get; set; }
    }
}