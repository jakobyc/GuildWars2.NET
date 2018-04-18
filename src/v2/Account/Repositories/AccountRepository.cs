using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuildWars2.NET.v2.Account.DTOs;
using GuildWars2.NET.Serialization.JSON;
using GuildWars2.NET.Data;

namespace GuildWars2.NET.v2.Account.Repositories
{
    // TODO: Add endpoints for pvp heroes:
    public class AccountRepository : GW2Repository
    {
        public AccountRepository(string apiKey) : base(apiKey) { }
        public AccountRepository(string apiKey, JsonDeserializer deserializer, JsonRetriever retriever) : base(apiKey, deserializer, retriever) { }

        public AccountInfo GetAccountInfo()
        {
            return Retrieve<AccountInfo>(new AccountInfo(), ApiKey);
        }

        public ICollection<AccountAchievement> GetAchievements()
        {
            return Retrieve<ICollection<AccountAchievement>>(new AccountAchievement(), ApiKey);
        }

        public AccountAchievement GetAchievement(int id)
        {
            string filter = string.Format("id={0}", id);
            return Retrieve<AccountAchievement>(new AccountAchievement(), filter);
        }

        public ICollection<BankItem> GetBankItems()
        {
            return Retrieve<ICollection<BankItem>>(new BankItem(), ApiKey);
        }

        public ICollection<string> GetCompletedDailyDungeons()
        {
            return Retrieve<ICollection<string>>(new DailyDungeon(), ApiKey);
        }

        public ICollection<string> GetDyes()
        {
            return Retrieve<ICollection<string>>(new DailyDungeon(), ApiKey);
        }

        public ICollection<Finisher> GetFinishers()
        {
            return Retrieve<ICollection<Finisher>>(new Dye(), ApiKey);
        }

        // TODO: Resolve against v2/gliders:
        public ICollection<int> GetGliders()
        {
            return Retrieve<ICollection<int>>(new Glider(), ApiKey);
        }

        public ICollection<Cat> GetHomeCats()
        {
            return Retrieve<ICollection<Cat>>(new Cat(), ApiKey);
        }

        public ICollection<string> GetHomeNodes()
        {
            return Retrieve<ICollection<string>>(new Node(), ApiKey);
        }

        public ICollection<SharedInventoryItem> GetSharedInventoryItems()
        {
            return Retrieve<ICollection<SharedInventoryItem>>(new SharedInventoryItem(), ApiKey);
        }

        // TODO: Resolve against v2/mailcarriers
        public ICollection<int> GetMailCarriers()
        {
            return Retrieve<ICollection<int>>(new MailCarrier(), ApiKey);
        }

        public ICollection<Mastery> GetMasteries()
        {
            return Retrieve<ICollection<Mastery>>(new Mastery(), ApiKey);
        }

        public MasteryPoints GetMasteryPoints()
        {
            return Retrieve<MasteryPoints>(new MasteryPoints(), ApiKey);
        }

        public ICollection<Material> GetMaterials()
        {
            return Retrieve<ICollection<Material>>(new Material(), ApiKey);
        }

        public ICollection<string> GetMiniatures()
        {
            return Retrieve<ICollection<string>>(new Miniature(), ApiKey);
        }

        public ICollection<string> GetOutfits()
        {
            return Retrieve<ICollection<string>>(new Outfit(), ApiKey);
        }

        // TODO: Resolve against v2/pvp/heroes:
        public ICollection<int> GetPvPHeroes()
        {
            return Retrieve<ICollection<int>>(new PvPHero(), ApiKey);
        }

        public ICollection<string> GetCompletedRaids()
        {
            return Retrieve<ICollection<string>>(new Raid(), ApiKey);
        }

        public ICollection<string> GetRecipes()
        {
            return Retrieve<ICollection<string>>(new Recipe(), ApiKey);
        }

        public ICollection<string> GetSkins()
        {
            return Retrieve<ICollection<string>>(new Skin(), ApiKey);
        }

        public ICollection<string> GetTitles()
        {
            return Retrieve<ICollection<string>>(new Title(), ApiKey);
        }

        public ICollection<WalletCurrency> GetWallet()
        {
            return Retrieve<ICollection<WalletCurrency>>(new WalletCurrency(), ApiKey);
        }
    }
}
