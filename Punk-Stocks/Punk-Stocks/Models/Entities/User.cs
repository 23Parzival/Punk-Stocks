using Punk_Stocks.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Punk_Stocks.Models.Entities
{
    internal class User
    {
        private int id;
        private string username = "";
        private string passwordHash = "";
        private decimal cashBalance;
        private AppTheme theme = AppTheme.Light;
        private AppLanguage language = AppLanguage.English;
        private DateTime createdAt = DateTime.Now;
        private bool isAdmin;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string PasswordHash
        {
            get { return passwordHash; }
            set { passwordHash = value; }
        }

        public decimal CashBalance
        {
            get { return cashBalance; }
            set { cashBalance = value; }
        }

        public AppTheme Theme
        {
            get { return theme; }
            set { theme = value; }
        }
        public AppLanguage Language
        {
            get { return language; }
            set { language = value; }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }
    }
}
