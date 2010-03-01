using IAmMap.CommandResults;

namespace IAmMap.Commands
{
    public interface IFetchCommand : ICommand<IFetchCommand, IFetchCommandResult>
    {
        int Uid { get; set; }
        int? StartUid { get; set; }
        int? EndUid { get; set; }
        string PartNo { get; set; }
    }
}