namespace IAmMap.CommandResults.Implementation
{
    public class SelectCommandResult : ISelectCommandResult
    {
        private readonly int _RecentMailCount;
        private readonly int _TotalMailCount;

        public SelectCommandResult(int totalMailCount, int recentMailCount)
        {
            _RecentMailCount = recentMailCount;
            _TotalMailCount = totalMailCount;
        }

        #region ISelectCommandResult Members

        public int TotalMailCount
        {
            get { return _TotalMailCount; }
        }

        public int RecentMailCount
        {
            get { return _RecentMailCount; }
        }

        #endregion
    }
}