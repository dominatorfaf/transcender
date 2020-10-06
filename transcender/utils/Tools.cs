using System;
using System.Collections.Generic;
using System.Text;

namespace Transcender.utils
{
    class Tools
    {
        // TODO make good encryption
        public static string Encrypt(string text)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(text));
        }

        public static string Decrypt(string text)
        {
            return Encoding.Unicode.GetString(Convert.FromBase64String(text));
        }
    }
}
