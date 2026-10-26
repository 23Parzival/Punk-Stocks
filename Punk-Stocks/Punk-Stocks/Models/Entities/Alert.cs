using Punk_Stocks.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Punk_Stocks.Models.Entities
{
    internal class Alert
    {
        private int id;
        private int userId;
        private int stockId;
        private decimal targetPrice;
        private AlertDirection direction;
        private bool isTriggered;
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
        public decimal TargetPrice
        {
            get { return targetPrice; }
            set { targetPrice = value; }
        }
        public AlertDirection Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        public bool IsTriggered
        {
            get { return isTriggered; }
            set { isTriggered = value; }
        }
        public Stock? Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public bool ShouldTrigger(decimal currentPrice)
        {
            if (isTriggered)
            {
                return false;
            }

            if (direction == AlertDirection.Above)
            {
                return currentPrice >= targetPrice;
            }
            else
            {
                return currentPrice <= targetPrice;
            }
        }
    }
}