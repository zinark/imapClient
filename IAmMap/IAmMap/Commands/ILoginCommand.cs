using IAmMap.CommandResults;

namespace IAmMap.Commands
{
    public interface ILoginCommand : ICommand<ILoginCommand, ILoginCommandResult>
    {
        string User { get; set; }
        string Password { get; set; }
    }
}