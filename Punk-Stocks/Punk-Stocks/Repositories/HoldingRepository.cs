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
    }
}
