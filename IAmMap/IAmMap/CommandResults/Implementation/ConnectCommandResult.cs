namespace IAmMap.CommandResults.Implementation
{
    public class ConnectCommandResult : IConnectCommandResult
    {
        private readonly string _Message;
        private readonly bool _Success;

        public ConnectCommandResult(string message, bool success)
        {
            _Message = message;
            _Success = success;
        }

        #region IConnectCommandResult Members

        public string Message
        {
            get { return _Message; }
        }

        public bool Success
        {
            get { return _Success; }
        }

        #endregion
    }
}