using System;
using System.Collections.Generic;
using System.Text;

namespace Punk_Stocks.Models.Entities
{
    internal class WatchlistItem
    {
        private int id;
        private int userId;
        private int stockId;
        private DateTime addedAt = DateTime.Now;
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
        public DateTime AddedAt
        {
            get { return addedAt; }
            set { addedAt = value; }
        }
        public Stock? Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}