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
    // TODO: Add endpoints for gliders, mail carriers, mastery points, and pvp heroes:
    public class AccountRepository : GW2Repository
    {
        public AccountRepository() : base() { }
        public AccountRepository(JsonDeserializer deserializer, JsonRetriever retriever) : base(deserializer, retriever) { }

        public AccountInfo GetAccountInfo(string accessToken)
        {
            AccountInfo account = new AccountInfo();

            string json = retriever.GetJson(account, accessToken);
            account = deserializer.Deserialize<AccountInfo>(json);

            return account;
        }

        public ICollection<AccountAchievement> GetAchievements(string accessToken)
        {
            string json = retriever.GetJson(new AccountAchievement(), accessToken);
            return deserializer.Deserialize<ICollection<AccountAchievement>>(json);
        }

        public AccountAchievement GetAchievement(string accessToken, int id)
        {
            AccountAchievement achievement = new AccountAchievement();

            string filter = string.Format("id={0}", id);
            string json = retriever.GetJson(achievement, accessToken, filter);
            achievement = deserializer.Deserialize<AccountAchievement>(json);

            return achievement;
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

        public ICollection<Mastery> GetMasteries(string accessToken)
        {
            return Retrieve<ICollection<Mastery>>(new Mastery(), accessToken);
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
