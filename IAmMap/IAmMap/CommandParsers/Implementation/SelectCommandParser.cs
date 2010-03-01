using System.Text.RegularExpressions;
using IAmMap.CommandResults;
using IAmMap.CommandResults.Implementation;

namespace IAmMap.CommandParsers.Implementation
{
    public class SelectCommandParser : AbstractCommandParser<ISelectCommandResult>, ISelectCommandParser
    {
        private const string PATTERN = @"\*.*?(\d+).*?EXISTS\r\n\*.*?(\d+).*?RECENT\r\n";

        #region ISelectCommandParser Members

        public override ISelectCommandResult Parse(string input)
        {
            Match match = GetMatch(input, PATTERN);
            int totalMailCount = int.Parse(match.Groups[1].ToString());
            int recentMailCount = int.Parse(match.Groups[2].ToString());

            return new SelectCommandResult(totalMailCount, recentMailCount);
        }

        #endregion
    }
}