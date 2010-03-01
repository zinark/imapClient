using IAmMap.Models;

namespace IAmMap.CommandResults
{
    public interface IFetchCommandResult : ICommandResult
    {
        Mail Mail { get; }
    }
}