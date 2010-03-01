using System.Collections.Generic;
using IAmMap.Commands;
using IAmMap.Models;

namespace IAmMap
{
    public interface IMailClient
    {
        IConnectCommand ConnectCommand { get; set; }
        ILoginCommand LoginCommand { get; set; }
        IListCommand ListCommand { get; set; }
        ISelectCommand SelectCommand { get; set; }
        ISearchCommand SearchCommand { get; set; }
        IFetchCommand FetchCommand { get; set; }
        ILogoutCommand LogoutCommand { get; set; }
        IDisconnectCommand DisconnectCommand { get; set; }

        bool Connect(string host, int port);
        void Login(string userName, string password);
        void Logout();
        IList<MailFolder> ListFolders();
        void SelectFolder(string folderName);
        IList<int> Search();
        Mail GetMail(int uid, string bodyPart);
        void Disconnect();
    }
}