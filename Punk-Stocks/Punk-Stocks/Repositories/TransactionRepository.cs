using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Punk_Stocks.Repositories
{
    internal class TransactionRepository
    {
        public List<Transaction> GetRecent(int userId, int count)
        {
            using (var db = new PunkStocksDBEntities())
            {
                return db.Transactions.AsNoTracking()
                    .Include(t => t.Stock)
                    .Where(t => t.UserID == userId)
                    .OrderByDescending(t => t.ExecutedAt)
                    .Take(count)
                    .ToList();
            }
        }
    }
}
