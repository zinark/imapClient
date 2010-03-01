namespace IAmMap.Protocols
{
    public interface IProtocol
    {
        void SetConnectionInfo(string address, string certificateAddress, int port);
        void SetConnectionInfo(string address, int port);

        string SendMessage(string message, string returnMessage);
        string SendMessage(string message);
        string Connect();
        void Disconnect();
    }
}