using System.Collections.Generic;
using IAmMap.CommandResults;
using IAmMap.Models;

namespace IAmMap
{
    public class ImapClient : AbstractMailClient
    {
        public override bool Connect(string host, int port)
        {
            ConnectCommand.Address = host;
            ConnectCommand.Port = port;
            return ConnectCommand.Execute().Success;
        }

        public override void Login(string userName, string password)
        {
            LoginCommand.User = userName;
            LoginCommand.Password = password;
            LoginCommand.Execute();
        }

        public override void Logout()
        {
            LogoutCommand.Execute();
        }

        public override IList<MailFolder> ListFolders()
        {
            return ListCommand.Execute().Folders;
        }

        public override void SelectFolder(string folderName)
        {
            SelectCommand.FolderName = folderName;
            SelectCommand.Execute();
        }

        public override IList<int> Search()
        {
            return SearchCommand.Execute().UIDList;
        }

        public override Mail GetMail(int uid, string bodyPart)
        {
            FetchCommand.Uid = uid;
            FetchCommand.PartNo = bodyPart;
            IFetchCommandResult result = FetchCommand.Execute();
            return result.Mail;
        }

        public override void Disconnect()
        {
            DisconnectCommand.Execute();
        }
    }
}