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
    }
}
