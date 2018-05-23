using System.Collections.Generic;

namespace GuildWars2.NET.v2.Characters.DTOs
{
    public interface ISkill
    {
        int EliteId { get; set; }
        int HealId { get; set; }
        ICollection<int> UtilitiesIDs { get; set; }
    }
}