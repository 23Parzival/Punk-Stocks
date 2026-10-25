using System;
using System.Collections.Generic;
using System.Text;

namespace Punk_Stocks.Models
{
    internal class Transaction
    {
        private int id;
        private int userId;
        private int stockId;
        private TransactionType type;
        private int quantity;
        private decimal pricePerShare;
        private DateTime executedAt = DateTime.Now;
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
        public TransactionType Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public decimal PricePerShare
        {
            get { return pricePerShare; }
            set { pricePerShare = value; }
        }
        public DateTime ExecutedAt
        {
            get { return executedAt; }
            set { executedAt = value; }
        }
        public Stock? Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public decimal Total
        {
            get { return quantity * pricePerShare; }
        }
    }
}