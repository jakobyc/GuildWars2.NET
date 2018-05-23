using GuildWars2.NET.Builders.Parameters;
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
        protected IParameterBuilder ParameterBuilder;

        private JsonDeserializer deserializer;
        private JsonRetriever retriever;
        protected string ApiKey;

        public GW2Repository(string apiKey) : this(apiKey, new JsonDeserializer(), new JsonRetriever()) { }

        public GW2Repository(string apiKey, JsonDeserializer deserializer, JsonRetriever retriever)
        {
            this.ApiKey = apiKey;
            this.deserializer = deserializer;
            this.retriever = retriever;

            ParameterBuilder = new ParameterBuilder();
        }

        /// <summary>
        /// Retrieve without an API key.
        /// </summary>
        protected T Retrieve<T>(IRetrievable retrievableObject)
        {
            string json = retriever.GetJson(retrievableObject);
            return deserializer.Deserialize<T>(json);
        }

        /// <summary>
        /// Retrieve with an API key.
        /// </summary>
        protected T RetrieveWithKey<T>(IRetrievable retrievableObject)
        {
            string json = retriever.GetJson(retrievableObject, ApiKey);
            return deserializer.Deserialize<T>(json);
        }

        /// <summary>
        /// Retrieve with an API key and a filter.
        /// </summary>
        protected T Retrieve<T>(IRetrievable retrievableObject, string filter)
        {
            string json = retriever.GetJson(retrievableObject, ApiKey, filter);
            return deserializer.Deserialize<T>(json);
        }
    }
}
