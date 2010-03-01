using System.Text.RegularExpressions;
using IAmMap.CommandResults;

namespace IAmMap.CommandParsers
{
    public abstract class AbstractCommandParser<TCommandResult> : ICommandParser<TCommandResult>
        where TCommandResult : ICommandResult
    {
        #region ICommandParser<TCommandResult> Members

        public abstract TCommandResult Parse(string input);

        object ICommandParser.Parse(string input)
        {
            return Parse(input);
        }

        #endregion

        protected MatchCollection GetMatches(string input, string pattern)
        {
            return Regex.Matches(input, pattern);
        }

        protected Match GetMatch(string input, string pattern)
        {
            return Regex.Match(input, pattern);
        }

        protected Match GetMatch(string input, string pattern, RegexOptions options)
        {
            return Regex.Match(input, pattern, options);
        }

        protected MatchCollection GetMatches(string input, string pattern, RegexOptions options)
        {
            return Regex.Matches(input, pattern, options);
        }
    }
}