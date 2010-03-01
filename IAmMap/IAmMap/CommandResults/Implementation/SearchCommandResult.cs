using System.Collections.Generic;

namespace IAmMap.CommandResults.Implementation
{
    public class SearchCommandResult : ISearchCommandResult
    {
        private readonly IList<int> _UidList;

        public SearchCommandResult(IList<int> uidList)
        {
            _UidList = uidList;
        }

        #region ISearchCommandResult Members

        public IList<int> UIDList
        {
            get { return _UidList; }
        }

        #endregion
    }
}