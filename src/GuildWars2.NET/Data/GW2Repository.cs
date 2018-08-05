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
            string json = retriever.GetJson(endpoint);
            return deserializer.Deserialize<T>(json);
        }

        protected T Retrieve<T>(IEndpointBuilder builder)
        {
            string json = retriever.GetJson(builder.Build());
            return deserializer.Deserialize<T>(json);
        }

        /// <summary>
        /// Retrieve a type based on a retrievable object.
        /// </summary>
        protected T Retrieve<T>(IRetrievable retrievable)
        {
            string json = retriever.GetJson(retrievable);
            return deserializer.Deserialize<T>(json);
        }

        protected IRetrievable CreateEndpoint(string endpoint)
        {
            return CreateEndpoint(endpoint, null, null);
        }

        protected IRetrievable CreateEndpoint(string endpoint, ICollection<string> parameters)
        {
            return CreateEndpoint(endpoint, null, parameters);
        }

        protected IRetrievable CreateEndpoint(string endpoint, string accessToken)
        {
            return CreateEndpoint(endpoint, accessToken, null);
        }

        protected IRetrievable CreateEndpoint(string endpoint, string accessToken, ICollection<string> parameters)
        {
            return new ApiEndpoint()
            {
                Endpoint = endpoint,
                Parameters = parameters ?? new List<string>(),
                AccessToken = accessToken
            };
        }
    }
}
