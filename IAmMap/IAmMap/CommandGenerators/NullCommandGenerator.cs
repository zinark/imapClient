using IAmMap.Commands;

namespace Atum.Imap.CommandGenerators
{
    public class NullCommandGenerator<TCommand> : AbstractCommandGenerator<TCommand> where TCommand : ICommand
    {
        public override string Generate(TCommand command)
        {
            return string.Empty;
        }
    }
}