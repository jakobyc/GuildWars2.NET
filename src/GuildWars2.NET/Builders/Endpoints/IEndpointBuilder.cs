namespace GuildWars2.NET.Builders.Endpoints
{
    public interface IEndpointBuilder
    {
        IEndpointBuilder AddEndpoint(string endpoint);
        IEndpointBuilder AddParameter(string parameterName, params string[] values);
        IEndpointBuilder AddParameter(string parameterName, params int[] values);
        string Build();
    }
}