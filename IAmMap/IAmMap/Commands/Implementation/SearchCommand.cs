using IAmMap.CommandResults;

namespace IAmMap.Commands.Implementation
{
    public class SearchCommand : AbstractCommand<ISearchCommand, ISearchCommandResult>, ISearchCommand
    {
        private readonly string _Filter;

        public SearchCommand() : this(string.Empty)
        {
        }

        public SearchCommand(string filter)
        {
            _Filter = filter;
        }

        #region ISearchCommand Members

        public string Filter
        {
            get { return _Filter; }
        }

        public override ISearchCommandResult Execute()
        {
            string response = Protocol.SendMessage(Generator.Generate(this));
            return Parser.Parse(response);
        }

        #endregion
    }
}