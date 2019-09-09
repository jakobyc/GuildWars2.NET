﻿using GuildWars2.NET.v2.Account.Repositories;
using GuildWars2.NET.v2.Achievements.Repositories;
using GuildWars2.NET.v2.Characters.Repositories;
using GuildWars2.NET.v2.Commerce.Repositories;
using GuildWars2.NET.v2.Guilds.Repositories;
using GuildWars2.NET.v2.Items.Repositories;
using GuildWars2.NET.v2.Misc.Repositories;
using GuildWars2.NET.v2.PvE.Repositories;
using GuildWars2.NET.v2.PvP.Repositories;
using GuildWars2.NET.v2.Skills.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET
{
    public class GW2Client
    {
        public string ApiKey { get; }
        public AccountRepository Account { get; }
        public AchievementRepository Achievements { get; }
        public CharacterRepository Characters { get; }
        public CommerceRepository Commerce { get; }
        public GuildRepository Guilds { get; }
        public ItemRepository Items { get; }
        public MiscRepository Misc { get; }
        public PvERepository PvE { get; }
        public PvPRepository PvP { get; }
        public SkillRepository Skills { get; }

        /// <summary>
        /// Client used to access the Guild Wars 2 REST API.
        /// </summary>
        /// <param name="apiKey">Official API key provided from ArenaNet.</param>
        public GW2Client(string apiKey = null)
        {
            Achievements = new AchievementRepository();
            Commerce = new CommerceRepository();
            Guilds = new GuildRepository();
            Items = new ItemRepository();
            Misc = new MiscRepository();
            PvE = new PvERepository();
            PvP = new PvPRepository();
            Skills = new SkillRepository();

            ApiKey = apiKey;
            Account = new AccountRepository(ApiKey);
            Characters = new CharacterRepository(ApiKey);
        }
    }
}