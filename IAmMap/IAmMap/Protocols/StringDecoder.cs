using System;
using System.Text;

namespace IAmMap.Protocols
{
    public static class StringDecoder
    {
        public static string DecodeBase64String(string encodedString)
        {
            byte[] bytes = Convert.FromBase64String(encodedString);
            var encoder = new UTF8Encoding();
            Decoder decoder = encoder.GetDecoder();
            int charCount = decoder.GetCharCount(bytes, 0, bytes.Length);
            var decodedMessage = new char[charCount];
            decoder.GetChars(bytes, 0, bytes.Length, decodedMessage, 0);
            return new string(decodedMessage);
        }
    }
}