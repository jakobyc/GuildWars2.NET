using GuildWars2.NET.Data;
using GuildWars2.NET.v2.PvP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Misc.Repositories
{
    public class MiscRepository : GW2Repository
    {
        public MiscRepository() : base() { }

        public TokenInfo GetTokenInfo(string apiKey)
        {
            return Retrieve<TokenInfo>($"tokeninfo?access_token={apiKey}");
        }
    }
}
