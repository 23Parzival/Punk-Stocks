using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Punk_Stocks.Repositories
{
    internal class HoldingRepository
    {
        public List<Holding> GetForUser(int userId)
        {
            using (var db = new PunkStocksDBEntities())
            {
                return db.Holdings.AsNoTracking()
                    .Include(h => h.Stock)
                    .Where(h => h.UserID == userId)
                    .OrderBy(h => h.Stock.Symbol)
                    .ToList();
            }
        }

        //these take the caller's db so a trade is saved in one SaveChanges
        public Holding Find(PunkStocksDBEntities db, int userId, int stockId)
        {
            return db.Holdings.FirstOrDefault(h => h.UserID == userId && h.StockID == stockId);
        }

        public void Add(PunkStocksDBEntities db, Holding holding)
        {
            db.Holdings.Add(holding);
        }

        public void Remove(PunkStocksDBEntities db, Holding holding)
        {
            db.Holdings.Remove(holding);
        }
    }
}
