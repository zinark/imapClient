using Atum.Imap.CommandGenerators;
using IAmMap.Commands;

namespace IAmMap.CommandGenerators.Implementation
{
    public class LogoutCommandGenerator : AbstractCommandGenerator<ILogoutCommand>,
                                          ILogoutCommandGenerator
    {
        private const string TEMPLATE = "? LOGOUT";

        #region ILogoutCommandGenerator Members

        public override string Generate(ILogoutCommand command)
        {
            return string.Format(TEMPLATE);
        }

        #endregion
    }
}