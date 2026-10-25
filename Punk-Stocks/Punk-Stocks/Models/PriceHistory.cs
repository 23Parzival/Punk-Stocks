using System;
using System.Collections.Generic;
using System.Text;

namespace Punk_Stocks.Models
{
    internal class PriceHistory
    {
        private int id;
        private int stockId;
        private decimal price;
        private DateTime recordedAt = DateTime.Now;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int StockId
        {
            get { return stockId; }
            set { stockId = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public DateTime RecordedAt
        {
            get { return recordedAt; }
            set { recordedAt = value; }
        }
    }
}