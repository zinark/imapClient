using IAmMap.CommandResults;

namespace IAmMap.CommandParsers.Implementation
{
    public class NullCommandParser<TCommandResult> : ICommandParser<TCommandResult>
        where TCommandResult : ICommandResult
    {
        #region ICommandParser<TCommandResult> Members

        public TCommandResult Parse(string input)
        {
            return default(TCommandResult);
        }

        object ICommandParser.Parse(string input)
        {
            return Parse(input);
        }

        #endregion
    }
}