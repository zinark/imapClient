namespace IAmMap.CommandResults
{
    public interface IConnectCommandResult : ICommandResult
    {
        string Message { get; }
        bool Success { get; }
    }
}