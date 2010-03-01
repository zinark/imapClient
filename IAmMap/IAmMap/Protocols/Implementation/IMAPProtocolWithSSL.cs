using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace IAmMap.Protocols.Implementation
{
    public class IMAPProtocolWithSSL : AbstractProtocol
    {
        private SslStream _SslStream;

        public IMAPProtocolWithSSL()
        {
        }

        public IMAPProtocolWithSSL(string address, int port) : base(address, port)
        {
        }

        public IMAPProtocolWithSSL(string address, string certificationAddress, int port)
            : base(address, certificationAddress, port)
        {
        }

        public IMAPProtocolWithSSL(string address, int port, Encoding encoding) : base(address, port, encoding)
        {
        }

        public override string Connect()
        {
            string response;
            try
            {
                _Client = new TcpClient();
                _Client.NoDelay = false;
                _Client.ReceiveTimeout = 60000;
                _Client.SendTimeout = 60000;

                _Client.Connect(_Address, _Port);
                NetworkStream netStream = _Client.GetStream();
                _SslStream = new SslStream(netStream, false, CertificationValidationCallback);
                _SslStream.ReadTimeout = 60000;
                _SslStream.WriteTimeout = 600000;

                _SslStream.AuthenticateAsClient(_CertificateAddress);
                response = GetMessage(_SslStream);
            }
            catch (Exception ex)
            {
                string err = "";
                err += "Problem occured while connecting. Address or Port may be invalid.";
                err += ex.Message;
                if (ex.InnerException != null)
                    err += ex.InnerException.Message;
                throw new ProtocolConnectionException(err);
            }
            return response;
        }

        public override string SendMessage(string message, string returnMessage)
        {
            string response;
            try
            {
                var writer = new StreamWriter(_SslStream, Encoding.ASCII);
                char[] cBuffer = message.ToCharArray();
                writer.WriteLine(cBuffer);
                writer.Flush();

                response = GetMessage(_SslStream);
            }
            catch (Exception ex)
            {
                throw new ProtocolConnectionException("Problem occured while sending message", ex);
            }

            if (response.StartsWith(returnMessage))
                return "";

            return response;
        }

        private static bool CertificationValidationCallback(object sender, X509Certificate certificate, X509Chain chain,
                                                            SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;

            if (sslPolicyErrors == SslPolicyErrors.RemoteCertificateChainErrors)
            {
                Console.WriteLine("Chain Invalid fetched data");
            }
            else if (sslPolicyErrors == SslPolicyErrors.RemoteCertificateNameMismatch)
            {
                Console.WriteLine("Name mismatch");
            }
            else if (sslPolicyErrors == SslPolicyErrors.RemoteCertificateNotAvailable)
            {
                Console.WriteLine("Certificate not available");
            }

            return true;
        }
    }
}