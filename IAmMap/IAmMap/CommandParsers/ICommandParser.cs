using IAmMap.CommandResults;

namespace IAmMap.CommandParsers
{
    public interface ICommandParser<TCommandResult> : ICommandParser where TCommandResult : ICommandResult
    {
        new TCommandResult Parse(string input);
    }


    public interface ICommandParser
    {
        object Parse(string input);
    }
}