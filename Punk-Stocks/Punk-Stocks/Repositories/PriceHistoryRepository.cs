using System;
using System.Linq;

namespace Punk_Stocks.Repositories
{
    internal class PriceHistoryRepository
    {
        public DateTime? GetLastRecorded()
        {
            using (var db = new PunkStocksDBEntities())
            {
                return db.PriceHistories.Max(p => (DateTime?)p.RecordedAt);
            }
        }

        public void DeleteOlderThan(DateTime cutoff)
        {
            using (var db = new PunkStocksDBEntities())
            {
                db.Database.ExecuteSqlCommand("DELETE FROM PriceHistories WHERE RecordedAt < @p0", cutoff);
            }
        }
    }
}
