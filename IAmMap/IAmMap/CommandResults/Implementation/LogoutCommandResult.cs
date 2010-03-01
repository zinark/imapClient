namespace IAmMap.CommandResults.Implementation
{
    public class LogoutCommandResult : ILogoutCommandResult
    {
        private readonly bool _Success;

        public LogoutCommandResult(bool success)
        {
            _Success = success;
        }

        #region ILogoutCommandResult Members

        public bool Success
        {
            get { return _Success; }
        }

        #endregion
    }
}