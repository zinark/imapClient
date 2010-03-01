using System;

namespace IAmMap.Protocols
{
    public class ProtocolConnectionException : Exception
    {
        public ProtocolConnectionException()
        {
        }

        public ProtocolConnectionException(string message)
            : base(message)
        {
        }

        public ProtocolConnectionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}