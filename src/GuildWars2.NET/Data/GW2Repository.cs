using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.Core.Data
{
    public abstract class GW2Repository
    {
        private JsonDeserializer deserializer;
        private JsonRetriever retriever;
        protected string ApiKey;


        public GW2Repository() : this(new JsonDeserializer(), new JsonRetriever()) { }
        public GW2Repository(JsonDeserializer deserializer, JsonRetriever retriever)
        {
            this.deserializer = deserializer;
            this.retriever = retriever;
        }
        public GW2Repository(string apiKey) : this(new JsonDeserializer(), new JsonRetriever())
        {
            this.ApiKey = apiKey;
        }
        public GW2Repository(string apiKey, JsonDeserializer deserializer, JsonRetriever retriever)
        {
            this.ApiKey = apiKey;
            this.deserializer = deserializer;
            this.retriever = retriever;
        }

        /// <summary>
        /// Retrieve without an API key.
        /// </summary>
        protected T Retrieve<T>(string endpoint)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint(endpoint);

            return Retrieve<T>(builder);
        }

        protected T Retrieve<T>(IEndpointBuilder builder)
        {
            if (!string.IsNullOrEmpty(ApiKey))
            {
                builder.AddParameter("access_token", ApiKey);
            }
            string json = retriever.GetJson(builder.Build());
            return deserializer.Deserialize<T>(json);
        }
    }
}
