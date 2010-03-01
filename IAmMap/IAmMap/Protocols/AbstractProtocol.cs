using System.IO;
using System.Net.Sockets;
using System.Text;

namespace IAmMap.Protocols
{
    public abstract class AbstractProtocol : IProtocol
    {
        protected const string DEFAULT_ADDRESS = "Default";
        protected const int DEFAULT_PORT = 143;
        protected const int MAX_BUFFER_SIZE = 1024*16;
        protected static readonly Encoding DEFAULT_ENCODING = Encoding.UTF8;

        protected readonly Encoding _Encoding;
        protected string _Address;
        protected string _CertificateAddress;
        protected TcpClient _Client;
        protected int _Port;

        #region "ctor"

        protected AbstractProtocol() : this(DEFAULT_ADDRESS, DEFAULT_ADDRESS, DEFAULT_PORT, DEFAULT_ENCODING)
        {
        }

        protected AbstractProtocol(string address, int port) : this(address, address, port, DEFAULT_ENCODING)
        {
        }

        protected AbstractProtocol(string address, int port, Encoding encoding) : this(address, address, port, encoding)
        {
        }

        protected AbstractProtocol(string address, string certificationAddress, int port)
            : this(address, certificationAddress, port, DEFAULT_ENCODING)
        {
        }

        protected AbstractProtocol(string address, string certificationAddress, int port, Encoding encoding)
        {
            _Address = address;
            _CertificateAddress = certificationAddress;
            _Port = port;
            _Encoding = encoding;
            _Client = new TcpClient();
        }

        #endregion

        #region IProtocol Members

        public void SetConnectionInfo(string address, int port)
        {
            _Address = address;
            _CertificateAddress = address;
            _Port = port;
        }

        public void SetConnectionInfo(string address, string certificateAddress, int port)
        {
            _Address = address;
            _CertificateAddress = certificateAddress;
            _Port = port;
        }

        public abstract string SendMessage(string message, string returnMessage);

        public string SendMessage(string message)
        {
            return SendMessage(message, "? BAD");
        }

        public abstract string Connect();

        public void Disconnect()
        {
            _Client.Close();
        }

        #endregion

        protected string GetMessage(Stream stream)
        {
            string response = "";
            bool canRead = true;
            var reader = new StreamReader(stream, _Encoding);

            while (canRead)
            {
                string line = reader.ReadLine();
                response += line + "\r\n";
                canRead = !(line.StartsWith("? OK") ||
                            line.StartsWith("? NO") ||
                            line.StartsWith("? BAD") || line.StartsWith("* OK"));
            }

            //Console.WriteLine(response);
            return response;
        }
    }
}