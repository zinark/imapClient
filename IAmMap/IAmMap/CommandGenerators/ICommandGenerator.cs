using IAmMap.Commands;

namespace IAmMap.CommandGenerators
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