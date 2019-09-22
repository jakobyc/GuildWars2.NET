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
        protected T Retrieve<T>(string endpoint, GW2RESTConfig config = null)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint(endpoint);

            return Retrieve<T>(builder, config);
        }

        protected async Task<T> RetrieveAsync<T>(string endpoint, GW2RESTConfig config = null)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint(endpoint);

            return await RetrieveAsync<T>(builder, config);
        }

        protected T Retrieve<T>(IEndpointBuilder builder, GW2RESTConfig config = null)
        {
            if (!string.IsNullOrEmpty(ApiKey))
            {
                if (config == null || config.IgnoreAuthentication == false)
                {
                    builder.AddParameter("access_token", ApiKey);
                }
            }
            string json = retriever.GetJson(builder);
            return deserializer.Deserialize<T>(json);
        }

        protected async Task<T> RetrieveAsync<T>(IEndpointBuilder builder, GW2RESTConfig config = null)
        {
            if (!string.IsNullOrEmpty(ApiKey))
            {
                if (config == null || config.IgnoreAuthentication == false)
                {
                    builder.AddParameter("access_token", ApiKey);
                }
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

    public class GW2RESTConfig
    {
        public bool IgnoreAuthentication { get; set; }
    }
}
