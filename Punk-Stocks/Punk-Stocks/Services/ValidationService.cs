using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Punk_Stocks.Services
{
    internal static class ValidationService
    {
        public static string ValidateUsername(string username)
        {
            if (username.Trim().Length < 4)
                return "Username must be at least 4 characters.";
            return null;
        }

        public static string ValidatePassword(string password)
        {
            if (password.Length < 8)
                return "Password must be at least 8 characters.";
            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit))
                return "Include an uppercase letter, a lowercase letter and a number.";
            return null;
        }

        public static string ValidateStartingCash(string input)
        {
            if (!decimal.TryParse(input, out decimal cash) || cash <= 0)
                return "Enter a positive number, e.g. 10000.";
            else if (cash > 300000 || cash < 1000)
                return "Starting cash cannot exceed 300000 and must be at least 1000.";
            return null;
        }
    }
}
