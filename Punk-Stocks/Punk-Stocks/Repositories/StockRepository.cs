using System;
using System.Collections.Generic;
using System.Linq;

namespace Punk_Stocks.Repositories
{
    internal class StockRepository
    {
        public List<Stock> GetAll()
        {
            using (var db = new PunkStocksDBEntities())
            {
                return db.Stocks.AsNoTracking().OrderBy(s => s.Symbol).ToList();
            }
        }

        public Stock Find(PunkStocksDBEntities db, int stockId)
        {
            return db.Stocks.Find(stockId);
        }
    }
}
