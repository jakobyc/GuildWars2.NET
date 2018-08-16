using System.Collections.Generic;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public interface ISkill
    {
        int EliteId { get; set; }
        int HealId { get; set; }
        ICollection<int> UtilitiesIDs { get; set; }
    }
}