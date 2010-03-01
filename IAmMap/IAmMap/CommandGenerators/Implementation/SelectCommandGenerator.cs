using Atum.Imap.CommandGenerators;
using IAmMap.Commands;

namespace IAmMap.CommandGenerators.Implementation
{
    public class SelectCommandGenerator : AbstractCommandGenerator<ISelectCommand>,
                                          ISelectCommandGenerator
    {
        private const string TEMPLATE = @"? SELECT ""{0}""";

        #region ISelectCommandGenerator Members

        public override string Generate(ISelectCommand command)
        {
            return string.Format(TEMPLATE,
                                 command.FolderName);
        }

        #endregion
    }
}