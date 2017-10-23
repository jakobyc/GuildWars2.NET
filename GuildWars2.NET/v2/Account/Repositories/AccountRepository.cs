using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuildWars2.NET.v2.Account.DTOs;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Account.Repositories
{
    // TODO: Add endpoints for gliders, mail carriers, mastery points, and pvp heroes:
    public class AccountRepository
    {
        private JsonDeserializer deserializer;
        private JsonRetriever retriever; 

        public AccountRepository() : this(new JsonDeserializer(), new JsonRetriever()) { }

        public AccountRepository(JsonDeserializer deserializer, JsonRetriever retriever)
        {
            this.deserializer = deserializer;
            this.retriever = retriever;
        }

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
            string json = retriever.GetJson(new BankItem(), accessToken);
            return deserializer.Deserialize<ICollection<BankItem>>(json);
        }

        public ICollection<string> GetCompletedDailyDungeons(string accessToken)
        {
            string json = retriever.GetJson(new DailyDungeon(), accessToken);
            return deserializer.Deserialize<ICollection<string>>(json);
        }

        public ICollection<string> GetDyes(string accessToken)
        {
            string json = retriever.GetJson(new Dye(), accessToken);
            return deserializer.Deserialize<ICollection<string>>(json);
        }

        public ICollection<Finisher> GetFinishers(string accessToken)
        {
            string json = retriever.GetJson(new Finisher(), accessToken);
            return deserializer.Deserialize<ICollection<Finisher>>(json);
        }

        public ICollection<Cat> GetHomeCats(string accessToken)
        {
            string json = retriever.GetJson(new Cat(), accessToken);
            return deserializer.Deserialize<ICollection<Cat>>(json);
        }

        public ICollection<string> GetHomeNodes(string accessToken)
        {
            string json = retriever.GetJson(new Node(), accessToken);
            return deserializer.Deserialize<ICollection<string>>(json);
        }

        public ICollection<SharedInventoryItem> GetSharedInventoryItems(string accessToken)
        {
            string json = retriever.GetJson(new SharedInventoryItem(), accessToken);
            return deserializer.Deserialize<ICollection<SharedInventoryItem>>(json);
        }

        public ICollection<Mastery> GetMasteries(string accessToken)
        {
            string json = retriever.GetJson(new Mastery(), accessToken);
            return deserializer.Deserialize<ICollection<Mastery>>(json);
        }

        public ICollection<Material> GetMaterials(string accessToken)
        {
            string json = retriever.GetJson(new Material(), accessToken);
            return deserializer.Deserialize<ICollection<Material>>(json);
        }

        public ICollection<string> GetMiniatures(string accessToken)
        {
            string json = retriever.GetJson(new Miniature(), accessToken);
            return deserializer.Deserialize<ICollection<string>>(json);
        }

        public ICollection<string> GetOutfits(string accessToken)
        {
            string json = retriever.GetJson(new Outfit(), accessToken);
            return deserializer.Deserialize<ICollection<string>>(json);
        }

        public ICollection<string> GetCompletedRaids(string accessToken)
        {
            string json = retriever.GetJson(new Raid(), accessToken);
            return deserializer.Deserialize<ICollection<string>>(json);
        }

        public ICollection<string> GetRecipes(string accessToken)
        {
            string json = retriever.GetJson(new Recipe(), accessToken);
            return deserializer.Deserialize<ICollection<string>>(json);
        }

        public ICollection<string> GetSkins(string accessToken)
        {
            string json = retriever.GetJson(new Skin(), accessToken);
            return deserializer.Deserialize<ICollection<string>>(json);
        }

        public ICollection<string> GetTitles(string accessToken)
        {
            string json = retriever.GetJson(new Title(), accessToken);
            return deserializer.Deserialize<ICollection<string>>(json);
        }

        public ICollection<WalletCurrency> GetWallet(string accessToken)
        {
            string json = retriever.GetJson(new WalletCurrency(), accessToken);
            return deserializer.Deserialize<ICollection<WalletCurrency>>(json);
        }
    }
}
