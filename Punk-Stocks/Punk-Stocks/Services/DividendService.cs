using Punk_Stocks.Repositories;
using System;
using System.Collections.Generic;

namespace Punk_Stocks.Services
{
    //pays every holding its dividend once per simulated month
    internal class DividendService
    {
        //21 trading days = one simulated month = 21 real hours (one real hour is one simulated day)
        private const int TradingDaysPerPayout = 21;
        private const int TradingDaysPerYear = 252;
        public static readonly TimeSpan PayoutInterval = TimeSpan.FromHours(TradingDaysPerPayout);

        private readonly HoldingRepository holdingRepository = new HoldingRepository();
        private readonly DividendRepository dividendRepository = new DividendRepository();

        //pays every payout time between from and to. returns true if anything was paid
        public bool PayDue(DateTime from, DateTime to)
        {
            bool paid = false;

            //payout times are fixed multiples of PayoutInterval, so every copy of the app agrees on them
            long first = from.Ticks / PayoutInterval.Ticks + 1;
            long last = to.Ticks / PayoutInterval.Ticks;

            for (long i = first; i <= last; i++)
            {
                if (Pay(new DateTime(i * PayoutInterval.Ticks)))
                    paid = true;
            }

            return paid;
        }

        private bool Pay(DateTime paidAt)
        {
            using (var db = new PunkStocksDBEntities())
            {
                //already paid
                if (dividendRepository.AnyPaidAt(db, paidAt))
                    return false;

                bool paid = false;
                foreach (Holding holding in holdingRepository.GetAll(db))
                {
                    //the yearly yield split into 12 monthly payments
                    decimal perShare = holding.Stock.CurrentPrice * holding.Stock.DividendYield * TradingDaysPerPayout / TradingDaysPerYear;
                    decimal amount = Math.Round(holding.Quantity * perShare, 2);
                    if (amount <= 0)
                        continue;

                    holding.User.CashBalance += amount;
                    dividendRepository.Add(db, new Dividend
                    {
                        UserID = holding.UserID,
                        StockID = holding.StockID,
                        Amount = amount,
                        PaidAt = paidAt
                    });
                    paid = true;
                }

                db.SaveChanges();
                return paid;
            }
        }
    }
}
