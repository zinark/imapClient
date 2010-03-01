using System.Collections.Generic;
using IAmMap.Models;

namespace IAmMap.CommandResults
{
    public interface IListCommandResult : ICommandResult
    {
        IList<MailFolder> Folders { get; }
        int FolderCount { get; }
    }
}