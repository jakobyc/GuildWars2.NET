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
        public AccountRepository() : base() { }
        public AccountRepository(JsonDeserializer deserializer, JsonRetriever retriever) : base(deserializer, retriever) { }

        public AccountInfo GetAccountInfo(string accessToken)
        {
            return Retrieve<AccountInfo>(new AccountInfo(), accessToken);
        }

        public ICollection<AccountAchievement> GetAchievements(string accessToken)
        {
            return Retrieve<ICollection<AccountAchievement>>(new AccountAchievement(), accessToken);
        }

        public AccountAchievement GetAchievement(string accessToken, int id)
        {
            string filter = string.Format("id={0}", id);
            return Retrieve<AccountAchievement>(new AccountAchievement(), accessToken, filter);
        }

        public ICollection<BankItem> GetBankItems(string accessToken)
        {
            return Retrieve<ICollection<BankItem>>(new BankItem(), accessToken);
        }

        public ICollection<string> GetCompletedDailyDungeons(string accessToken)
        {
            return Retrieve<ICollection<string>>(new DailyDungeon(), accessToken);
        }

        public ICollection<string> GetDyes(string accessToken)
        {
            return Retrieve<ICollection<string>>(new DailyDungeon(), accessToken);
        }

        public ICollection<Finisher> GetFinishers(string accessToken)
        {
            return Retrieve<ICollection<Finisher>>(new Dye(), accessToken);
        }

        // TODO: Resolve against v2/gliders:
        public ICollection<int> GetGliders(string accessToken)
        {
            return Retrieve<ICollection<int>>(new Glider(), accessToken);
        }

        public ICollection<Cat> GetHomeCats(string accessToken)
        {
            return Retrieve<ICollection<Cat>>(new Cat(), accessToken);
        }

        public ICollection<string> GetHomeNodes(string accessToken)
        {
            return Retrieve<ICollection<string>>(new Node(), accessToken);
        }

        public ICollection<SharedInventoryItem> GetSharedInventoryItems(string accessToken)
        {
            return Retrieve<ICollection<SharedInventoryItem>>(new SharedInventoryItem(), accessToken);
        }

        // TODO: Resolve against v2/mailcarriers
        public ICollection<int> GetMailCarriers(string accessToken)
        {
            return Retrieve<ICollection<int>>(new MailCarrier(), accessToken);
        }

        public ICollection<Mastery> GetMasteries(string accessToken)
        {
            return Retrieve<ICollection<Mastery>>(new Mastery(), accessToken);
        }

        public MasteryPoints GetMasteryPoints(string accessToken)
        {
            return Retrieve<MasteryPoints>(new MasteryPoints(), accessToken);
        }

        public ICollection<Material> GetMaterials(string accessToken)
        {
            return Retrieve<ICollection<Material>>(new Material(), accessToken);
        }

        public ICollection<string> GetMiniatures(string accessToken)
        {
            return Retrieve<ICollection<string>>(new Miniature(), accessToken);
        }

        public ICollection<string> GetOutfits(string accessToken)
        {
            return Retrieve<ICollection<string>>(new Outfit(), accessToken);
        }

        // TODO: Resolve against v2/pvp/heroes:
        public ICollection<int> GetPvPHeroes(string accessToken)
        {
            return Retrieve<ICollection<int>>(new PvPHero(), accessToken);
        }

        public ICollection<string> GetCompletedRaids(string accessToken)
        {
            return Retrieve<ICollection<string>>(new Raid(), accessToken);
        }

        public ICollection<string> GetRecipes(string accessToken)
        {
            return Retrieve<ICollection<string>>(new Recipe(), accessToken);
        }

        public ICollection<string> GetSkins(string accessToken)
        {
            return Retrieve<ICollection<string>>(new Skin(), accessToken);
        }

        public ICollection<string> GetTitles(string accessToken)
        {
            return Retrieve<ICollection<string>>(new Title(), accessToken);
        }

        public ICollection<WalletCurrency> GetWallet(string accessToken)
        {
            return Retrieve<ICollection<WalletCurrency>>(new WalletCurrency(), accessToken);
        }
    }
}
