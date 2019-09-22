using GuildWars2.NET.Builders.Endpoints;
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
        private readonly JsonDeserializer deserializer;
        private readonly JsonRetriever retriever;
        protected string ApiKey;


        public GW2Repository() : this(new JsonDeserializer(), new JsonRetriever()) { }
        public GW2Repository(JsonDeserializer deserializer, JsonRetriever retriever)
        {
            this.deserializer = deserializer;
            this.retriever = retriever;
        }
        public GW2Repository(string apiKey) : this(apiKey, new JsonDeserializer(), new JsonRetriever())
        {
        }
        public GW2Repository(string apiKey, JsonDeserializer deserializer, JsonRetriever retriever) : this(deserializer, retriever)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Retrieve without an API key.
        /// </summary>
        protected T Retrieve<T>(string endpoint)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint(endpoint);

            return Retrieve<T>(builder);
        }

        protected async Task<T> RetrieveAsync<T>(string endpoint)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint(endpoint);

            return await RetrieveAsync<T>(builder);
        }

        protected T Retrieve<T>(IEndpointBuilder builder)
        {
            if (!string.IsNullOrEmpty(ApiKey))
            {
                builder.AddParameter("access_token", ApiKey);
            }
            string json = retriever.GetJson(builder);
            return deserializer.Deserialize<T>(json);
        }

        protected async Task<T> RetrieveAsync<T>(IEndpointBuilder builder)
        {
            if (!string.IsNullOrEmpty(ApiKey))
            {
                builder.AddParameter("access_token", ApiKey);
            }
            string json = await retriever.GetJsonAsync(builder);
            return deserializer.Deserialize<T>(json);
        }

        protected void ValidateToken()
        {
            if (string.IsNullOrWhiteSpace(ApiKey))
            {
                throw new Exception("This call requires an API Key.");
            }
        }
    }
}
