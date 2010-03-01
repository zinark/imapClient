using IAmMap.Commands;

namespace IAmMap.CommandGenerators.Implementation
{
    public class ListCommandGenerator : AbstractCommandGenerator<IListCommand>,
                                        IListCommandGenerator
    {
        private const string TEMPLATE = @"? LIST {0} {1}";

        #region IListCommandGenerator Members

        public override string Generate(IListCommand command)
        {
            return string.Format(TEMPLATE,
                                 command.Path,
                                 command.Name);
        }

        #endregion
    }
}