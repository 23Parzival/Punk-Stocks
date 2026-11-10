using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Punk_Stocks.Repositories
{
    internal class WatchlistRepository
    {
        public bool Add(int userId, int stockId)
        {
            using (var db = new PunkStocksDBEntities())
            {
                if (db.WatchlistItems.Any(w => w.UserID == userId && w.StockID == stockId))
                    return false;

                db.WatchlistItems.Add(new WatchlistItem { UserID = userId, StockID = stockId, AddedAt = DateTime.Now });
                db.SaveChanges();
                return true;
            }
        }
    }
}
