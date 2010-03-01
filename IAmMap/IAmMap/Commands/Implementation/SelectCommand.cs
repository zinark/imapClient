using IAmMap.CommandResults;

namespace IAmMap.Commands.Implementation
{
    public class SelectCommand : AbstractCommand<ISelectCommand, ISelectCommandResult>, ISelectCommand
    {
        public SelectCommand(string folderName)
        {
            FolderName = folderName;
        }

        #region ISelectCommand Members

        public string FolderName { get; set; }

        public override ISelectCommandResult Execute()
        {
            string response = Protocol.SendMessage(Generator.Generate(this));
            return Parser.Parse(response);
        }

        #endregion
    }
}