using IAmMap.CommandResults;
using IAmMap.CommandResults.Implementation;

namespace IAmMap.Commands.Implementation
{
    public class ConnectCommand : AbstractCommand<IConnectCommand, IConnectCommandResult>, IConnectCommand
    {
        private string _Address;
        private int _Port;

        public ConnectCommand(string address, int port)
        {
            _Address = address;
            _Port = port;
        }

        #region IConnectCommand Members

        public override IConnectCommandResult Execute()
        {
            Protocol.SetConnectionInfo(_Address, _Port);
            string message = Protocol.Connect();
            return new ConnectCommandResult(message, message.Contains("* OK"));
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public int Port
        {
            get { return _Port; }
            set { _Port = value; }
        }

        #endregion
    }
}