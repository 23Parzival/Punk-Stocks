using Punk_Stocks.Models.Enums;
using Punk_Stocks.Repositories;
using System;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace Punk_Stocks.Services
{
    internal class AuthService
    {
        private const int WorkFactor = 12;

        private readonly UserRepository users = new UserRepository();

        public AuthResult Register(string username, string password, decimal startingCash)
        {
            username = (username ?? "").Trim();
            password = password ?? "";

            if (users.UsernameExists(username))
                return AuthResult.Fail(LanguageManager.Get("Auth_UsernameTaken"));

            var user = new User
            {
                Username = username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password, WorkFactor),
                CashBalance = startingCash,
                Theme = (int)AppTheme.Light,
                Language = (int)AppLanguage.English,
                IsAdmin = false,
                CreatedAt = DateTime.Now
            };

            users.Add(user);
            return AuthResult.Ok(user);
        }

        public AuthResult Login(string username, string password)
        {
            username = (username ?? "").Trim();
            password = password ?? "";

            if (username.Length == 0 || password.Length == 0)
                return AuthResult.Fail(LanguageManager.Get("Auth_MissingCredentials"));

            User user = users.GetByUsername(username);

            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                return AuthResult.Fail(LanguageManager.Get("Auth_InvalidCredentials"));

            return AuthResult.Ok(user);
        }
    }
}