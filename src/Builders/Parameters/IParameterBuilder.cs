namespace GuildWars2.NET.Builders.Parameters
{
    public interface IParameterBuilder
    {
        string Build();
        string Build(string parameterName, int[] queryValues);
        string Build(string parameterName, string[] queryValues);
    }
}