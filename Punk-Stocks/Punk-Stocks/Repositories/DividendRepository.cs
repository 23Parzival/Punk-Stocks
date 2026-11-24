using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Punk_Stocks.Repositories
{
    internal class DividendRepository
    {
        public List<Dividend> GetForUser(int userId)
        {
            using (var db = new PunkStocksDBEntities())
            {
                return db.Dividends.AsNoTracking()
                    .Include(d => d.Stock)
                    .Where(d => d.UserID == userId)
                    .OrderByDescending(d => d.PaidAt)
                    .ToList();
            }
        }

        //these take the caller's db so a payout is saved in one SaveChanges
        public bool AnyPaidAt(PunkStocksDBEntities db, DateTime paidAt)
        {
            return db.Dividends.Any(d => d.PaidAt == paidAt);
        }

        public void Add(PunkStocksDBEntities db, Dividend dividend)
        {
            db.Dividends.Add(dividend);
        }
    }
}
