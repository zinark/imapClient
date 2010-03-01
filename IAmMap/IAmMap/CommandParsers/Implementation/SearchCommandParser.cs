using System.Collections.Generic;
using System.Text.RegularExpressions;
using IAmMap.CommandResults;
using IAmMap.CommandResults.Implementation;

namespace IAmMap.CommandParsers.Implementation
{
    public class SearchCommandParser : AbstractCommandParser<ISearchCommandResult>, ISearchCommandParser
    {
        private const string PATTERN = @"\* SEARCH (.*)";

        #region ISearchCommandParser Members

        public override ISearchCommandResult Parse(string input)
        {
            IList<int> uidList = new List<int>();
            Match match = GetMatch(input, PATTERN);

            string uidString = match.Groups[1].ToString();
            if (string.IsNullOrEmpty(uidString)) return new SearchCommandResult(uidList);

            foreach (string uid in uidString.Split(' '))
            {
                uidList.Add(int.Parse(uid));
            }
            return new SearchCommandResult(uidList);
        }

        #endregion
    }
}