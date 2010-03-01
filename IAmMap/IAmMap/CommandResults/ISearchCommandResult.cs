using System.Collections.Generic;

namespace IAmMap.CommandResults
{
    public interface ISearchCommandResult : ICommandResult
    {
        IList<int> UIDList { get; }
    }
}