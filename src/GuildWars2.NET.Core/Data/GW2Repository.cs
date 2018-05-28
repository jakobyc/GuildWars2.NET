using GuildWars2.NET.Core.Builders.Parameters;
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

        // TODO: Remove IRetrievable from DTOs, create an Endpoint class that implements IRetrievable. Add filter and token variables to Endpoint.

        /// <summary>
        /// Retrieve without an API key.
        /// </summary>
        protected T Retrieve<T>(IRetrievable retrievableObject)
        {
            string json = retriever.GetJson(retrievableObject);
            return deserializer.Deserialize<T>(json);
        }

        /// <summary>
        /// Retrieve without an API key.
        /// </summary>
        protected T Retrieve<T>(string endpoint)
        {
            string json = retriever.GetJson(endpoint);
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

        /// <summary>
        /// Retrieve a type based on a retrievable object.
        /// </summary>
        protected T Retrieve<T>(IRetrievableMock retrievable)
        {
            string json = retriever.GetJson(retrievable);
            return deserializer.Deserialize<T>(json);
        }

        protected IRetrievableMock CreateEndpoint(string endpoint)
        {
            return CreateEndpoint(endpoint, null, null);
        }

        protected IRetrievableMock CreateEndpoint(string endpoint, ICollection<string> parameters)
        {
            return CreateEndpoint(endpoint, null, parameters);
        }

        protected IRetrievableMock CreateEndpoint(string endpoint, string accessToken)
        {
            return CreateEndpoint(endpoint, accessToken, null);
        }

        protected IRetrievableMock CreateEndpoint(string endpoint, string accessToken, ICollection<string> parameters)
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
