using IAmMap.CommandResults;

namespace IAmMap.Commands
{
    public interface ISelectCommand : ICommand<ISelectCommand, ISelectCommandResult>
    {
        string FolderName { get; set; }
    }
}