using IAmMap.CommandResults;

namespace IAmMap.Commands
{
    public interface IConnectCommand : ICommand<IConnectCommand, IConnectCommandResult>
    {
        string Address { get; set; }
        int Port { get; set; }
    }
}