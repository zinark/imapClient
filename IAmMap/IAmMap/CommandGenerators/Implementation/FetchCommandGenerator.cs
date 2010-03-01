using System;
using Atum.Imap.CommandGenerators;
using IAmMap.Commands;

namespace IAmMap.CommandGenerators.Implementation
{
    public class FetchCommandGenerator : AbstractCommandGenerator<IFetchCommand>,
                                         IFetchCommandGenerator
    {
        private const string TEMPLATE = "? UID FETCH {0}:{1} BODY[{2}]";

        #region IFetchCommandGenerator Members

        public override string Generate(IFetchCommand command)
        {
            int startUid = 0;
            int endUid = 0;

            if (command.StartUid == null && command.EndUid == null)
            {
                startUid = command.Uid;
                endUid = command.Uid;
            }

            if (command.Uid > 0)
            {
                startUid = command.Uid;
                endUid = command.Uid;
            }

            return String.Format(TEMPLATE,
                                 startUid, endUid, command.PartNo);
        }

        #endregion
    }
}