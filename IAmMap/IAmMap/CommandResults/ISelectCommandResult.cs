namespace IAmMap.CommandResults
{
    public interface ISelectCommandResult : ICommandResult
    {
        int TotalMailCount { get; }
        int RecentMailCount { get; }
    }
}