using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Transcender.utils
{
    class FieldValidator
    {
        public static bool validateUser(string input)
        {
            if (input.Contains(" ") || !Regex.IsMatch(input, @"^[a-zA-Z0-9._]+$")){
                return false;
            }

            return true;
        }

        public static bool validatePassword(string input)
        {
            if (input.Contains(" ") || !Regex.IsMatch(input, @"^[a-zA-Z0-9._/?!#$%^&*]+$"))
            {
                return false;
            }

            return true;
        }
    }
}
