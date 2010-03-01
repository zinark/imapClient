using IAmMap.CommandResults;

namespace IAmMap.Commands
{
    public interface ISearchCommand : ICommand<ISearchCommand, ISearchCommandResult>
    {
        string Filter { get; }
    }
}