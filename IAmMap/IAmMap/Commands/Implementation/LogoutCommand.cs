using IAmMap.CommandResults;

namespace IAmMap.Commands.Implementation
{
    public class LogoutCommand : AbstractCommand<ILogoutCommand, ILogoutCommandResult>, ILogoutCommand
    {
        #region ILogoutCommand Members

        public override ILogoutCommandResult Execute()
        {
            string response = Protocol.SendMessage(Generator.Generate(this));
            return Parser.Parse(response);
        }

        #endregion
    }
}