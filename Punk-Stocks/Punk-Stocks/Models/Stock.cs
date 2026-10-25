using System;
using System.Collections.Generic;
using System.Text;

namespace Punk_Stocks.Models
{
    internal class Stock
    {
        private int id;
        private string symbol = "";
        private string companyName = "";
        private string sector = "";
        private decimal currentPrice;
        private decimal volatility;
        private decimal dividendYield;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public string Sector
        {
            get { return sector; }
            set { sector = value; }
        }
        public decimal CurrentPrice
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }
        public decimal Volatility
        {
            get { return volatility; }
            set { volatility = value; }
        }
        public decimal DividendYield
        {
            get { return dividendYield; }
            set { dividendYield = value; }
        }
    }
}
