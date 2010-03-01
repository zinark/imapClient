namespace IAmMap.CommandResults
{
    public interface ILoginCommandResult : ICommandResult
    {
        bool Successed { get; set; }
    }
}