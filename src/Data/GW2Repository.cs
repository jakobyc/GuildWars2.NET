using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.Data
{
    public abstract class GW2Repository
    {
        protected JsonDeserializer deserializer;
        protected JsonRetriever retriever;

        public GW2Repository() : this(new JsonDeserializer(), new JsonRetriever()) { }

        public GW2Repository(JsonDeserializer deserializer, JsonRetriever retriever)
        {
            this.deserializer = deserializer;
            this.retriever = retriever;
        }

        public T Retrieve<T>(IRetrievable retrievableObject, string accessToken)
        {
            string json = retriever.GetJson(retrievableObject, accessToken);
            return deserializer.Deserialize<T>(json);
        }

        public T Retrieve<T>(IRetrievable retrievableObject, string accessToken, string filter)
        {
            string json = retriever.GetJson(retrievableObject, accessToken, filter);
            return deserializer.Deserialize<T>(json);
        }
    }
}
