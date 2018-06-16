using System.Collections.Generic;

namespace GuildWars2.NET.Core.v2.Characters.Entities
{
    public interface ISkill
    {
        int EliteId { get; set; }
        int HealId { get; set; }
        ICollection<int> UtilitiesIDs { get; set; }
    }
}