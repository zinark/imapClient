using IAmMap.Models;

namespace IAmMap.CommandResults.Implementation
{
    public class FetchCommandResult : IFetchCommandResult
    {
        private readonly Mail _Mail;

        public FetchCommandResult(Mail mail)
        {
            _Mail = mail;
        }

        #region IFetchCommandResult Members

        public Mail Mail
        {
            get { return _Mail; }
        }

        #endregion
    }
}