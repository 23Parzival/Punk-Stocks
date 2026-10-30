namespace Punk_Stocks.Services
{
    internal sealed class AuthResult
    {
        public bool Success { get; private set; }
        public string Error { get; private set; }
        public User User { get; private set; }

        public static AuthResult Ok(User user)
        {
            return new AuthResult { Success = true, User = user };
        }

        public static AuthResult Fail(string error)
        {
            return new AuthResult { Success = false, Error = error };
        }
    }
}