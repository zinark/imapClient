using System.Collections.Generic;
using System.Text.RegularExpressions;
using IAmMap.CommandResults;
using IAmMap.CommandResults.Implementation;
using IAmMap.Models;

namespace IAmMap.CommandParsers.Implementation
{
    public class ListCommandParser : AbstractCommandParser<IListCommandResult>, IListCommandParser
    {
        private const string PATTERN = "\\* LIST.*?\"(.*?)\".*?(.*?)\r\n";

        #region IListCommandParser Members

        public override IListCommandResult Parse(string input)
        {
            IList<MailFolder> folders = new List<MailFolder>();
            foreach (Match match in GetMatches(input, PATTERN))
            {
                string path = match.Groups[1].ToString();
                string name = match.Groups[2].ToString();
                folders.Add(new MailFolder(path, name));
            }
            return new ListCommandResult(folders);
        }

        #endregion
    }
}