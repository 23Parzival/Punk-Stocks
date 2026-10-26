using System;
using System.Collections.Generic;
using System.Text;

namespace Punk_Stocks.Models.Entities
{
    internal class Dividend
    {
        private int id;
        private int userId;
        private int stockId;
        private decimal amount;
        private DateTime paidAt = DateTime.Now;
        private Stock? stock;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public int StockId
        {
            get { return stockId; }
            set { stockId = value; }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public DateTime PaidAt
        {
            get { return paidAt; }
            set { paidAt = value; }
        }
        public Stock? Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}