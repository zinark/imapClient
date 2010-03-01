using System.Text.RegularExpressions;
using IAmMap.CommandResults;
using IAmMap.CommandResults.Implementation;
using IAmMap.Models;
using IAmMap.Protocols;

namespace IAmMap.CommandParsers.Implementation
{
    public class FetchCommandParser : AbstractCommandParser<IFetchCommandResult>, IFetchCommandParser
    {
        private const string PATTERN = @"\*.*?}\r\n(.*)UID";

        #region IFetchCommandParser Members

        public override IFetchCommandResult Parse(string input)
        {
            Match match = GetMatch(input, PATTERN, RegexOptions.Singleline);
            string encodedBody = match.Groups[1].ToString();
            string body = StringDecoder.DecodeBase64String(encodedBody);
            var mail = new Mail();
            mail.Body = body;
            return new FetchCommandResult(mail);
        }

        #endregion
    }
}