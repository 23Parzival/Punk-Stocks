using System;

namespace Punk_Stocks.Repositories
{
    internal class PriceHistoryRepository
    {
        public void DeleteOlderThan(DateTime cutoff)
        {
            using (var db = new PunkStocksDBEntities())
            {
                db.Database.ExecuteSqlCommand("DELETE FROM PriceHistories WHERE RecordedAt < @p0", cutoff);
            }
        }
    }
}
