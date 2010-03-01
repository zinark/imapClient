using System.Collections.Generic;
using IAmMap.Commands;
using IAmMap.Models;

namespace IAmMap
{
    public abstract class AbstractMailClient : IMailClient
    {
        private IConnectCommand _ConnectCommand;
        private IDisconnectCommand _DisconnectCommand;
        private IFetchCommand _FetchCommand;
        private IListCommand _ListCommand;
        private ILoginCommand _LoginCommand;
        private ILogoutCommand _LogoutCommand;
        private ISearchCommand _SearchCommand;
        private ISelectCommand _SelectCommand;

        #region IMailClient Members

        public IConnectCommand ConnectCommand
        {
            get { return _ConnectCommand; }
            set { _ConnectCommand = value; }
        }

        public ILoginCommand LoginCommand
        {
            get { return _LoginCommand; }
            set { _LoginCommand = value; }
        }

        public IListCommand ListCommand
        {
            get { return _ListCommand; }
            set { _ListCommand = value; }
        }

        public ISelectCommand SelectCommand
        {
            get { return _SelectCommand; }
            set { _SelectCommand = value; }
        }

        public ISearchCommand SearchCommand
        {
            get { return _SearchCommand; }
            set { _SearchCommand = value; }
        }

        public IFetchCommand FetchCommand
        {
            get { return _FetchCommand; }
            set { _FetchCommand = value; }
        }

        public ILogoutCommand LogoutCommand
        {
            get { return _LogoutCommand; }
            set { _LogoutCommand = value; }
        }

        public IDisconnectCommand DisconnectCommand
        {
            get { return _DisconnectCommand; }
            set { _DisconnectCommand = value; }
        }

        public abstract bool Connect(string host, int port);
        public abstract void Login(string userName, string password);
        public abstract void Logout();
        public abstract IList<MailFolder> ListFolders();
        public abstract void SelectFolder(string folderName);
        public abstract IList<int> Search();
        public abstract Mail GetMail(int uid, string bodyPart);
        public abstract void Disconnect();

        #endregion
    }
}