using IAmMap.CommandResults;
using IAmMap.CommandResults.Implementation;

namespace IAmMap.Commands.Implementation
{
    public class DisconnectCommand : AbstractCommand<IDisconnectCommand, INullCommandResult>, IDisconnectCommand
    {
        #region IDisconnectCommand Members

        public override INullCommandResult Execute()
        {
            Protocol.Disconnect();
            return new NullCommandResult();
        }

        #endregion
    }
}