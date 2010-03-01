using IAmMap.CommandResults;

namespace IAmMap.Commands.Implementation
{
    public class FetchCommand : AbstractCommand<IFetchCommand, IFetchCommandResult>, IFetchCommand
    {
        private const string DEFAULT_PART_NO = "HEADER";
        private int? _EndUid;
        private string _PartNo;
        private int? _StartUid;
        private int _Uid;

        public FetchCommand(int uid, string partNo) : this(uid, null, null, partNo)
        {
        }

        public FetchCommand(int startUid, int endUid, string partNo) : this(0, startUid, endUid, partNo)
        {
        }

        public FetchCommand(int uid) : this(uid, null, null, DEFAULT_PART_NO)
        {
        }

        public FetchCommand(int uid, int? startUID, int? endUID, string partNo)
        {
            _Uid = uid;
            _EndUid = endUID;
            _StartUid = startUID;
            _PartNo = partNo;
        }

        #region IFetchCommand Members

        public override IFetchCommandResult Execute()
        {
            string response = Protocol.SendMessage(Generator.Generate(this));
            return Parser.Parse(response);
        }


        public int Uid
        {
            get { return _Uid; }
            set { _Uid = value; }
        }

        public int? StartUid
        {
            get { return _StartUid; }
            set { _StartUid = value; }
        }

        public int? EndUid
        {
            get { return _EndUid; }
            set { _EndUid = value; }
        }

        public string PartNo
        {
            get { return _PartNo; }
            set { _PartNo = value; }
        }

        #endregion
    }
}