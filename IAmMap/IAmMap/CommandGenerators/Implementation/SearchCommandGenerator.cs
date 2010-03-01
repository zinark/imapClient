using IAmMap.Commands;

namespace IAmMap.CommandGenerators.Implementation
{
    public class SearchCommandGenerator : AbstractCommandGenerator<ISearchCommand>,
                                          ISearchCommandGenerator
    {
        private const string TEMPLATE = @"? UID SEARCH {0}";

        #region ISearchCommandGenerator Members

        public override string Generate(ISearchCommand command)
        {
            return string.Format(TEMPLATE, GetFilterType(command));
        }

        #endregion

        private static string GetFilterType(ISearchCommand command)
        {
            if (command.Filter == string.Empty)
                return "ALL";
            return command.Filter;
        }
    }
}