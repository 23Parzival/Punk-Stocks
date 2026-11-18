using Punk_Stocks.Models.Enums;
using Punk_Stocks.Repositories;
using System;

namespace Punk_Stocks.Services
{
    internal class TradeService
    {
        private readonly UserRepository users = new UserRepository();
        private readonly StockRepository stocks = new StockRepository();
        private readonly HoldingRepository holdings = new HoldingRepository();
        private readonly TransactionRepository transactions = new TransactionRepository();

        public TradeResult Buy(int userId, int stockId, int quantity)
        {
            if (quantity <= 0)
                return TradeResult.Fail(LanguageManager.Get("Trade_InvalidQuantity"));

            using (var db = new PunkStocksDBEntities())
            {
                User user = users.Find(db, userId);
                Stock stock = stocks.Find(db, stockId);
                if (user == null || stock == null)
                    return TradeResult.Fail(LanguageManager.Get("Trade_NotFound"));

                decimal total = stock.CurrentPrice * quantity;
                if (total > user.CashBalance)
                    return TradeResult.Fail(LanguageManager.Format("Trade_NotEnoughCash", total.ToString("C2"), user.CashBalance.ToString("C2")));

                Holding holding = holdings.Find(db, userId, stockId);
                if (holding == null)
                {
                    holdings.Add(db, new Holding { UserID = userId, StockID = stockId, Quantity = quantity, AvgCost = stock.CurrentPrice });
                }
                else
                {
                    decimal oldCost = holding.AvgCost * holding.Quantity;
                    holding.Quantity += quantity;
                    holding.AvgCost = Math.Round((oldCost + total) / holding.Quantity, 2);
                }

                user.CashBalance -= total;
                AddTransaction(db, userId, stockId, TransactionType.Buy, quantity, stock.CurrentPrice);

                db.SaveChanges();

                return TradeResult.Ok(LanguageManager.Format("Trade_Bought", quantity, stock.Symbol, total.ToString("C2")), user.CashBalance);
            }
        }

        public TradeResult Sell(int userId, int stockId, int quantity)
        {
            if (quantity <= 0)
                return TradeResult.Fail(LanguageManager.Get("Trade_InvalidQuantity"));

            using (var db = new PunkStocksDBEntities())
            {
                User user = users.Find(db, userId);
                Stock stock = stocks.Find(db, stockId);
                if (user == null || stock == null)
                    return TradeResult.Fail(LanguageManager.Get("Trade_NotFound"));

                Holding holding = holdings.Find(db, userId, stockId);
                int owned = holding == null ? 0 : holding.Quantity;
                if (quantity > owned)
                    return TradeResult.Fail(LanguageManager.Format("Trade_NotEnoughShares", owned, stock.Symbol));

                decimal total = stock.CurrentPrice * quantity;

                holding.Quantity -= quantity;
                if (holding.Quantity == 0)
                    holdings.Remove(db, holding);

                user.CashBalance += total;
                AddTransaction(db, userId, stockId, TransactionType.Sell, quantity, stock.CurrentPrice);

                db.SaveChanges();

                return TradeResult.Ok(LanguageManager.Format("Trade_Sold", quantity, stock.Symbol, total.ToString("C2")), user.CashBalance);
            }
        }

        private void AddTransaction(PunkStocksDBEntities db, int userId, int stockId, TransactionType type, int quantity, decimal price)
        {
            transactions.Add(db, new Transaction
            {
                UserID = userId,
                StockID = stockId,
                TransactionType = (int)type,
                Quantity = quantity,
                PricePerShare = price,
                ExecutedAt = DateTime.Now
            });
        }
    }
}
