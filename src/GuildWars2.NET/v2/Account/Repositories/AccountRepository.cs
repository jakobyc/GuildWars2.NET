using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuildWars2.NET.Core.v2.Account.Entities;
using GuildWars2.NET.Core.Serialization.JSON;
using GuildWars2.NET.Core.Data;

namespace GuildWars2.NET.Core.v2.Account.Repositories
{
    // TODO: Add endpoints for pvp heroes:
    public class AccountRepository : GW2Repository
    {
        public AccountRepository(string apiKey) : base(apiKey) { }
        public AccountRepository(string apiKey, JsonDeserializer deserializer, JsonRetriever retriever) : base(apiKey, deserializer, retriever) { }

        public AccountInfo GetAccountInfo()
        {
            return Retrieve<AccountInfo>(CreateEndpoint("account", ApiKey));
        }

        public ICollection<AccountAchievement> GetAchievements()
        {
            return Retrieve<ICollection<AccountAchievement>>(CreateEndpoint("account/achievements", ApiKey));
        }

        public AccountAchievement GetAchievement(int id)
        {
            ICollection<string> parameters = new List<string>();
            parameters.Add(string.Format("id={0}", id));

            return Retrieve<AccountAchievement>(CreateEndpoint("account/achievements", ApiKey, parameters));
        }

        public ICollection<BankItem> GetBankItems()
        {
            return Retrieve<ICollection<BankItem>>(CreateEndpoint("account/bank", ApiKey));
        }

        public ICollection<string> GetCompletedDailyDungeons()
        {
            return Retrieve<ICollection<string>>(CreateEndpoint("account/dungeons", ApiKey));
        }

        public ICollection<string> GetDyes()
        {
            return Retrieve<ICollection<string>>(CreateEndpoint("account/dyes", ApiKey));
        }

        public ICollection<Finisher> GetFinishers()
        {
            return Retrieve<ICollection<Finisher>>(CreateEndpoint("account/finishers", ApiKey));
        }

        // TODO: Resolve against v2/gliders:
        public ICollection<int> GetGliders()
        {
            return Retrieve<ICollection<int>>(CreateEndpoint("account/gliders", ApiKey));
        }

        public ICollection<Cat> GetHomeCats()
        {
            return Retrieve<ICollection<Cat>>(CreateEndpoint("account/home/cats", ApiKey));
        }

        public ICollection<string> GetHomeNodes()
        {
            return Retrieve<ICollection<string>>(CreateEndpoint("account/home/nodes", ApiKey));
        }

        public ICollection<SharedInventoryItem> GetSharedInventoryItems()
        {
            return Retrieve<ICollection<SharedInventoryItem>>(CreateEndpoint("account/inventory", ApiKey));
        }

        // TODO: Resolve against v2/mailcarriers
        public ICollection<int> GetMailCarriers()
        {
            return Retrieve<ICollection<int>>(CreateEndpoint("account/mailcarriers", ApiKey));
        }

        public ICollection<Mastery> GetMasteries()
        {
            return Retrieve<ICollection<Mastery>>(CreateEndpoint("account/masteries", ApiKey));
        }

        public MasteryPoints GetMasteryPoints()
        {
            return Retrieve<MasteryPoints>(CreateEndpoint("account/mastery/points", ApiKey));
        }

        public ICollection<Material> GetMaterials()
        {
            return Retrieve<ICollection<Material>>(CreateEndpoint("account/materials", ApiKey));
        }

        public ICollection<string> GetMiniatures()
        {
            return Retrieve<ICollection<string>>(CreateEndpoint("account/minis", ApiKey));
        }

        public ICollection<string> GetOutfits()
        {
            return Retrieve<ICollection<string>>(CreateEndpoint("account/outfits", ApiKey));
        }

        // TODO: Resolve against v2/pvp/heroes:
        public ICollection<int> GetPvPHeroes()
        {
            return Retrieve<ICollection<int>>(CreateEndpoint("account/pvp/heroes", ApiKey));
        }

        public ICollection<string> GetCompletedRaids()
        {
            return Retrieve<ICollection<string>>(CreateEndpoint("account/raids", ApiKey));
        }

        public ICollection<string> GetRecipes()
        {
            return Retrieve<ICollection<string>>(CreateEndpoint("account/recipes", ApiKey));
        }

        public ICollection<string> GetSkins()
        {
            return Retrieve<ICollection<string>>(CreateEndpoint("account/skins", ApiKey));
        }

        public ICollection<string> GetTitles()
        {
            return Retrieve<ICollection<string>>(CreateEndpoint("account/titles", ApiKey));
        }

        public ICollection<WalletCurrency> GetWallet()
        {
            return Retrieve<ICollection<WalletCurrency>>(CreateEndpoint("account/wallet", ApiKey));
        }
    }
}
