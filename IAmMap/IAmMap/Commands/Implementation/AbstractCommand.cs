using IAmMap.CommandGenerators;
using IAmMap.CommandParsers;
using IAmMap.CommandResults;
using IAmMap.Protocols;

namespace IAmMap.Commands.Implementation
{
    public abstract class AbstractCommand<TCommand, TCommandResult> : ICommand<TCommand, TCommandResult>
        where TCommandResult : ICommandResult
        where TCommand : ICommand<TCommand, TCommandResult>
    {
        private ICommandGenerator<TCommand> _Generator;
        private ICommandParser<TCommandResult> _Parser;
        private IProtocol _Protocol;

        public ICommandGenerator<TCommand> Generator
        {
            get { return _Generator; }
            set { _Generator = value; }
        }

        #region ICommand<TCommand,TCommandResult> Members

        public IProtocol Protocol
        {
            get { return _Protocol; }
            set { _Protocol = value; }
        }

        public abstract TCommandResult Execute();

        ICommandGenerator ICommand.Generator
        {
            get { return Generator; }
            set { Generator = (ICommandGenerator<TCommand>) value; }
        }

        ICommandGenerator<TCommand> ICommand<TCommand, TCommandResult>.Generator
        {
            get { return _Generator; }
            set { _Generator = value; }
        }

        ICommandParser ICommand.Parser
        {
            get { return Parser; }
            set { Parser = (ICommandParser<TCommandResult>) value; }
        }

        object ICommand.Execute()
        {
            return Execute();
        }

        public ICommandParser<TCommandResult> Parser
        {
            get { return _Parser; }
            set { _Parser = value; }
        }

        #endregion

        public AbstractCommand<TCommand, TCommandResult> SetProtocol(IProtocol protocol)
        {
            _Protocol = protocol;
            return this;
        }

        public AbstractCommand<TCommand, TCommandResult> SetGenerator(ICommandGenerator generator)
        {
            _Generator = (ICommandGenerator<TCommand>) generator;
            return this;
        }

        public AbstractCommand<TCommand, TCommandResult> SetParser(ICommandParser<TCommandResult> parser)
        {
            _Parser = parser;
            return this;
        }
    }
}