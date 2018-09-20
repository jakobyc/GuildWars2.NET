using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuildWars2.NET.v2.Account.Entities;
using GuildWars2.NET.Serialization.JSON;
using GuildWars2.NET.Data;
using GuildWars2.NET.Builders.Endpoints;

namespace GuildWars2.NET.v2.Account.Repositories
{
    public class AccountRepository : GW2Repository
    {
        public AccountRepository(string apiKey) : base(apiKey) { }
        public AccountRepository(string apiKey, JsonDeserializer deserializer, JsonRetriever retriever) : base(apiKey, deserializer, retriever) { }

        public AccountInfo GetAccountInfo()
        {
            return Retrieve<AccountInfo>("account");
        }

        public ICollection<AccountAchievement> GetAchievements()
        {
            return Retrieve<ICollection<AccountAchievement>>("account/achievements");
        }

        public AccountAchievement GetAchievement(int id)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("account/achievements")
                                                            .AddParameter("id", id);

            return Retrieve<AccountAchievement>(builder);
        }

        public ICollection<BankItem> GetBankItems()
        {
            return Retrieve<ICollection<BankItem>>("account/bank");
        }

        public ICollection<string> GetCompletedDailyDungeons()
        {
            return Retrieve<ICollection<string>>("account/dungeons");
        }

        public ICollection<string> GetDyes()
        {
            return Retrieve<ICollection<string>>("account/dyes");
        }

        public ICollection<Finisher> GetFinishers()
        {
            return Retrieve<ICollection<Finisher>>("account/finishers");
        }

        // TODO: Resolve against v2/gliders:
        public ICollection<int> GetGliders()
        {
            return Retrieve<ICollection<int>>("account/gliders");
        }

        public ICollection<Cat> GetHomeCats()
        {
            return Retrieve<ICollection<Cat>>("account/home/cats");
        }

        public ICollection<string> GetHomeNodes()
        {
            return Retrieve<ICollection<string>>("account/home/nodes");
        }

        public ICollection<SharedInventoryItem> GetSharedInventoryItems()
        {
            return Retrieve<ICollection<SharedInventoryItem>>("account/inventory");
        }

        // TODO: Resolve against v2/mailcarriers
        public ICollection<int> GetMailCarriers()
        {
            return Retrieve<ICollection<int>>("account/mailcarriers");
        }

        public ICollection<Mastery> GetMasteries()
        {
            return Retrieve<ICollection<Mastery>>("account/masteries");
        }

        public MasteryPoints GetMasteryPoints()
        {
            return Retrieve<MasteryPoints>("account/mastery/points");
        }

        public ICollection<Material> GetMaterials()
        {
            return Retrieve<ICollection<Material>>("account/materials");
        }

        public ICollection<string> GetMiniatures()
        {
            return Retrieve<ICollection<string>>("account/minis");
        }

        public ICollection<string> GetOutfits()
        {
            return Retrieve<ICollection<string>>("account/outfits");
        }

        public ICollection<PvPGame> GetPvPGames()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("pvp/games")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<PvPGame>>(builder);
        }

        // TODO: Resolve against v2/pvp/heroes:
        public ICollection<int> GetPvPHeroes()
        {
            return Retrieve<ICollection<int>>("account/pvp/heroes");
        }

        public ICollection<PvPStandings> GetPvPStandings()
        {
            return Retrieve<ICollection<PvPStandings>>("pvp/standings");
        }

        public ICollection<string> GetCompletedRaids()
        {
            return Retrieve<ICollection<string>>("account/raids");
        }

        public ICollection<string> GetRecipes()
        {
            return Retrieve<ICollection<string>>("account/recipes");
        }

        public ICollection<string> GetSkins()
        {
            return Retrieve<ICollection<string>>("account/skins");
        }

        public ICollection<string> GetTitles()
        {
            return Retrieve<ICollection<string>>("account/titles");
        }

        public ICollection<WalletCurrency> GetWallet()
        {
            return Retrieve<ICollection<WalletCurrency>>("account/wallet");
        }
    }
}
