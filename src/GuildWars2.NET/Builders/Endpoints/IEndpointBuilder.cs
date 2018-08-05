namespace GuildWars2.NET.Builders.Endpoints
{
    public interface IEndpointBuilder
    {
        IEndpointBuilder AddEndpoint(string endpoint);
        IEndpointBuilder AddParameter(string parameterName, string[] values);
        IEndpointBuilder AddParameter(string parameterName, int[] values);
        string Build();
    }
}