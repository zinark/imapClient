using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace IAmMap.Protocols.Implementation
{
    public class IMAPProtocol : AbstractProtocol
    {
        public IMAPProtocol()
        {
        }

        public IMAPProtocol(string address, int port) : base(address, port)
        {
        }

        public IMAPProtocol(string address, int port, Encoding encoding) : base(address, port, encoding)
        {
        }

        public override string Connect()
        {
            string response;
            try
            {
                _Client = new TcpClient {NoDelay = true, ReceiveTimeout = 15000, SendTimeout = 15000};

                _Client.Connect(_Address, _Port);
                NetworkStream stream = _Client.GetStream();
                response = GetMessage(stream);
            }
            catch (Exception ex)
            {
                throw new ProtocolConnectionException(
                    "Problem occured while connecting. Address or Port may be invalid.", ex);
            }
            return response;
        }

        public override string SendMessage(string message, string returnMessage)
        {
            string response = "";
            try
            {
                NetworkStream stream = _Client.GetStream();
                var writer = new StreamWriter(stream, Encoding.ASCII);
                char[] cBuffer = message.ToCharArray();
                writer.WriteLine(cBuffer);
                writer.Flush();
                response = GetMessage(stream);
            }
            catch (Exception ex)
            {
                throw new ProtocolConnectionException("Problem occured while sending message", ex);
            }

            if (response.StartsWith(returnMessage))
                return "";

            return response;
        }
    }
}