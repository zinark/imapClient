using System.Collections.Generic;
using IAmMap.Models;

namespace IAmMap.CommandResults.Implementation
{
    public class ListCommandResult : IListCommandResult
    {
        private IList<MailFolder> _Folders;

        public ListCommandResult(IList<MailFolder> folders)
        {
            _Folders = folders;
        }

        #region IListCommandResult Members

        public IList<MailFolder> Folders
        {
            get { return _Folders; }
            set { _Folders = value; }
        }

        public int FolderCount
        {
            get { return _Folders.Count; }
        }

        #endregion
    }
}