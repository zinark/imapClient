using IAmMap.CommandResults;

namespace IAmMap.Commands
{
    public interface IListCommand : ICommand<IListCommand, IListCommandResult>
    {
        string Path { get; }
        string Name { get; }
    }
}