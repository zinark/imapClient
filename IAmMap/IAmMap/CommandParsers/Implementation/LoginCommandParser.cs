using System.Text.RegularExpressions;
using IAmMap.CommandResults;
using IAmMap.CommandResults.Implementation;

namespace IAmMap.CommandParsers.Implementation
{
    public class LoginCommandParser : AbstractCommandParser<ILoginCommandResult>, ILoginCommandParser
    {
        private const string PATTERN = @"\? OK";

        #region ILoginCommandParser Members

        public override ILoginCommandResult Parse(string input)
        {
            bool successed = false;

            Match match = GetMatch(input, PATTERN);
            if (match.Groups[1] != null)
                successed = true;

            return new LoginCommandResult(successed);
        }

        #endregion
    }
}