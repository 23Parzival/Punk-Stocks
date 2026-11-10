using System;

namespace Punk_Stocks.Services
{
    internal static class SessionManager
    {
        public static User CurrentUser { get; private set; }
        public static bool IsLoggedIn { get { return CurrentUser != null; } }
        public static event EventHandler CashChanged;

        public static void SignIn(User user) { CurrentUser = user; }
        public static void SignOut() { CurrentUser = null; }
        public static void UpdateCash(decimal cashBalance)
        {
            if (CurrentUser == null)
                return;

            CurrentUser.CashBalance = cashBalance;
            CashChanged.Invoke(null, EventArgs.Empty);
        }
    }
}