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

        //new prices and their history points saved together
        public void SavePrices(Dictionary<int, decimal> prices, List<PriceHistory> history)
        {
            using (var db = new PunkStocksDBEntities())
            {
                foreach (Stock stock in db.Stocks)
                {
                    decimal price;
                    if (prices.TryGetValue(stock.StockID, out price))
                        stock.CurrentPrice = price;
                }

                db.PriceHistories.AddRange(history);
                db.SaveChanges();
            }
        }
    }
}
