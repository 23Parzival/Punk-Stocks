using System;
using System.Collections.Generic;
using System.Text;

namespace Punk_Stocks.Models
{
    internal class User
    {
        private int id;
        private string username = "";
        private string passwordHash = "";
        private decimal cashBalance;
        private string theme = "light";
        private string language = "en";
        private DateTime createdAt = DateTime.Now;

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

        public string Theme
        {
            get { return theme; }
            set { theme = value; }
        }

        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }
    }
}
