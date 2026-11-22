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
                StartingCash = startingCash,
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

        public AuthResult ChangeUsername(int userId, string newUsername)
        {
            newUsername = (newUsername ?? "").Trim();

            string error = ValidationService.ValidateUsername(newUsername);
            if (error != null)
                return AuthResult.Fail(error);

            if (users.UsernameExists(newUsername))
                return AuthResult.Fail(LanguageManager.Get("Auth_UsernameTaken"));

            User user = users.GetById(userId);
            if (user == null)
                return AuthResult.Fail(LanguageManager.Get("Auth_InvalidCredentials"));

            users.UpdateUsername(userId, newUsername);
            user.Username = newUsername;
            return AuthResult.Ok(user);
        }

        public AuthResult ChangePassword(int userId, string currentPassword, string newPassword)
        {
            currentPassword = currentPassword ?? "";
            newPassword = newPassword ?? "";

            User user = users.GetById(userId);
            if (user == null || !BCrypt.Net.BCrypt.Verify(currentPassword, user.PasswordHash))
                return AuthResult.Fail(LanguageManager.Get("Auth_WrongPassword"));

            string error = ValidationService.ValidatePassword(newPassword);
            if (error != null)
                return AuthResult.Fail(error);

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword, WorkFactor);
            users.UpdatePassword(userId, user.PasswordHash);
            return AuthResult.Ok(user);
        }
    }
}