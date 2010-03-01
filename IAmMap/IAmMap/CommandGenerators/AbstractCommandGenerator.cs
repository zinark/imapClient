using IAmMap.Commands;

namespace IAmMap.CommandGenerators
{
    public abstract class AbstractCommandGenerator<TCommand> : ICommandGenerator<TCommand>
        where TCommand : ICommand
    {
        #region ICommandGenerator<TCommand> Members

        public abstract string Generate(TCommand command);

        public string Generate(object command)
        {
            return Generate((TCommand) command);
        }

        #endregion
    }
}