using System.Linq;

namespace Punk_Stocks.Services
{
    internal static class ValidationService
    {
        public static string ValidateUsername(string username)
        {
            username = (username ?? "").Trim();
            if (username.Length < 4)
                return LanguageManager.Get("Validation_UsernameTooShort");
            else if (username.Length > 50)
                return LanguageManager.Get("Validation_UsernameTooLong");
            return null;
        }

        public static string ValidatePassword(string password)
        {
            password = password ?? "";
            if (password.Length < 8)
                return LanguageManager.Get("Validation_PasswordTooShort");
            if (password.Length > 128)
                return LanguageManager.Get("Validation_PasswordTooLong");
            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit))
                return LanguageManager.Get("Validation_PasswordComplexity");
            return null;
        }

        public static string ValidateStartingCash(string input)
        {
            if (!decimal.TryParse(input, out decimal cash) || cash <= 0)
                return LanguageManager.Get("Validation_CashInvalid");
            else if (cash > 300000 || cash < 1000)
                return LanguageManager.Get("Validation_CashRange");
            return null;
        }
    }
}
