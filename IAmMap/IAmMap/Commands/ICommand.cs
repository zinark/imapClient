using IAmMap.CommandGenerators;
using IAmMap.CommandParsers;
using IAmMap.CommandResults;
using IAmMap.Protocols;

namespace IAmMap.Commands
{
    public interface ICommand
    {
        ICommandGenerator Generator { get; set; }
        ICommandParser Parser { get; set; }
        IProtocol Protocol { get; set; }
        object Execute();
    }


    public interface ICommand<TCommand, TCommandResult> : ICommand where TCommand : ICommand<TCommand, TCommandResult>
                                                                   where TCommandResult : ICommandResult
    {
        new ICommandGenerator<TCommand> Generator { get; set; }
        new ICommandParser<TCommandResult> Parser { get; set; }
        new IProtocol Protocol { get; set; }
        new TCommandResult Execute();
    }
}