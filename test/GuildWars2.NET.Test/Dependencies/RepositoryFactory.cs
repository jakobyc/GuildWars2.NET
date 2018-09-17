using GuildWars2.NET.v2.Account.Repositories;
using GuildWars2.NET.v2.Achievements.Repositories;
using GuildWars2.NET.v2.Characters.Repositories;
using GuildWars2.NET.v2.Items.Repositories;
using GuildWars2.NET.v2.PvE.Repositories;
using GuildWars2.NET.v2.PvP.Repositories;
using GuildWars2.NET.Test.Tests;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using GuildWars2.NET.v2.Misc.Repositories;
using GuildWars2.NET.v2.Skills.Repositories;

namespace GuildWars2.NET.Test.Dependencies
{
    public class RepositoryFactory
    {
        public RepositoryFactory() { }

        public AccountRepository GetAccountRepository()
        {
            return new AccountRepository(Config.GetApiKey());
        }

        public AchievementRepository GetAchievementRepository()
        {
            return new AchievementRepository();
        }

        public CharacterRepository GetCharacterRepository()
        {
            return new CharacterRepository(Config.GetApiKey());
        }

        public ItemRepository GetItemRepository()
        {
            return new ItemRepository();
        }

        public MiscRepository GetMiscRepository()
        {
            return new MiscRepository();
        }

        public PvERepository GetPvERepository()
        {
            return new PvERepository();
        }

        public PvPRepository GetPvPRepository()
        {
            return new PvPRepository();
        }

        public SkillRepository GetSkillRepository()
        {
            return new SkillRepository();
        }
    }
}
