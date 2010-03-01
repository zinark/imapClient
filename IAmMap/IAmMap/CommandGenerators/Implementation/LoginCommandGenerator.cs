using IAmMap.Commands;

namespace IAmMap.CommandGenerators.Implementation
{
    public class LoginCommandGenerator : AbstractCommandGenerator<ILoginCommand>,
                                         ILoginCommandGenerator
    {
        private const string TEMPLATE = "? LOGIN {0} {1}";

        #region ILoginCommandGenerator Members

        public override string Generate(ILoginCommand command)
        {
            return string.Format(TEMPLATE,
                                 command.User,
                                 command.Password);
        }

        #endregion
    }
}