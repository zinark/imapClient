using System.Text.RegularExpressions;
using IAmMap.CommandResults;
using IAmMap.CommandResults.Implementation;

namespace IAmMap.CommandParsers.Implementation
{
    public class ConnectCommandParser : AbstractCommandParser<IConnectCommandResult>, IConnectCommandParser
    {
        private const string PARSE_PATTERN = "^* OK (.*)\r\n";

        #region IConnectCommandParser Members

        public override IConnectCommandResult Parse(string input)
        {
            Match matched = GetMatch(input, PARSE_PATTERN);
            string connectionMessage = matched.Groups[1].ToString();
            return new ConnectCommandResult(connectionMessage, input.Contains("? OK"));
        }

        #endregion
    }
}