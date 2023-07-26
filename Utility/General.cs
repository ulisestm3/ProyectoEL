using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utility
{
    public static class General
    {
        public static bool ValidateEmail(string? email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-.]+\.[a-zA-Z0-9-.]+$";
            if (email != null)
            {
                return Regex.Match(email, pattern).Success;
            }
            return false;
        }
    }
}
