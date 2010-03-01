namespace IAmMap.CommandResults
{
    public interface ILogoutCommandResult : ICommandResult
    {
        bool Success { get; }
    }
}