using IAmMap.Commands;

namespace Atum.Imap.CommandGenerators
{
    public interface ICommandGenerator
    {
        string Generate(object command);
    }


    public interface ICommandGenerator<TCommand> : ICommandGenerator where TCommand : ICommand
    {
        string Generate(TCommand command);
    }
}