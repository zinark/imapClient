using System;
using IAmMap.CommandResults;

namespace IAmMap.Commands.Implementation
{
    public class ListCommand : AbstractCommand<IListCommand, IListCommandResult>, IListCommand
    {
        private const string DEFAULT_NAME = "*";
        private const string DEFAULT_PATH = "";


        private readonly string _Name;
        private readonly string _Path;

        public ListCommand() : this(DEFAULT_NAME, DEFAULT_PATH)
        {
        }

        public ListCommand(string name) : this(DEFAULT_PATH, name)
        {
        }

        public ListCommand(string path, string name)
        {
            _Path = "\"" + path + "\"";
            _Name = "\"" + name + "\"";
        }

        #region IListCommand Members

        public override IListCommandResult Execute()
        {
            throw new NotImplementedException();
        }

        public string Path
        {
            get { return _Path; }
        }

        public string Name
        {
            get { return _Name; }
        }

        #endregion
    }
}