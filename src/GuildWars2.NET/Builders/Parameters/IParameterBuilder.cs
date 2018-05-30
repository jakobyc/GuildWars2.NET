namespace GuildWars2.NET.Core.Builders.Parameters
{
    public interface IParameterBuilder
    {
        string Build(string parameterName, int[] queryValues);
        string Build(string parameterName, string[] queryValues);
    }
}