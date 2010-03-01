using System.Text.RegularExpressions;
using IAmMap.CommandResults;
using IAmMap.CommandResults.Implementation;

namespace IAmMap.CommandParsers.Implementation
{
    public class LogoutCommandParser : AbstractCommandParser<ILogoutCommandResult>, ILogoutCommandParser
    {
        private const string PATTERN = @"\? OK";

        #region ILogoutCommandParser Members

        public override ILogoutCommandResult Parse(string input)
        {
            bool successed = false;

            Match match = GetMatch(input, PATTERN);
            if (match.Groups[1] != null)
                successed = true;

            return new LogoutCommandResult(successed);
        }

        #endregion
    }
}