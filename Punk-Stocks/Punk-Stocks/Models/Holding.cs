using System;
using System.Collections.Generic;
using System.Text;

namespace Punk_Stocks.Models
{
    internal class Holding
    {
        private int id;
        private int userId;
        private int stockId;
        private int quantity;
        private decimal avgCost;
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
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public decimal AvgCost
        {
            get { return avgCost; }
            set { avgCost = value; }
        }
        public Stock? Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public decimal CurrentValue
        {
            get { return stock == null ? 0m : Quantity * stock.CurrentPrice; }
        }
        //total amount you paid for the shares you currently hold
        public decimal CostBasis
        {
            get { return Quantity * AvgCost; }
        }
        //difference between what your shares are worth now and what you paid for them
        public decimal GainLoss
        {
            get { return CurrentValue - CostBasis; }
        }
        //percentage of prev
        public decimal GainLossPercent
        {
            get { return CostBasis == 0m ? 0m : GainLoss / CostBasis; }
        }
    }
}
