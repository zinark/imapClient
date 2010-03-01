using IAmMap.CommandResults;

namespace IAmMap.Commands.Implementation
{
    public class LoginCommand : AbstractCommand<ILoginCommand, ILoginCommandResult>, ILoginCommand
    {
        private string _Password;
        private string _User;

        public LoginCommand(string user, string password)
        {
            _User = user;
            _Password = password;
        }

        #region ILoginCommand Members

        public override ILoginCommandResult Execute()
        {
            string response = Protocol.SendMessage(Generator.Generate(this));
            return Parser.Parse(response);
        }

        public string User
        {
            get { return _User; }
            set { _User = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        #endregion
    }
}