using Punk_Stocks.Repositories;
using System;
using System.Collections.Generic;

namespace Punk_Stocks.Services
{
    //moves every stock price on a timer while the app is open
    internal class PriceSimulator
    {
        public static readonly TimeSpan TickInterval = TimeSpan.FromSeconds(10);

        //one real hour counts as one simulated day
        private static readonly TimeSpan SimulatedDay = TimeSpan.FromHours(1);

        //history is saved less often than prices change to keep the table small
        private static readonly TimeSpan HistoryInterval = TimeSpan.FromMinutes(5);

        private static readonly TimeSpan HistoryKept = TimeSpan.FromDays(30);
        private static readonly TimeSpan CleanupInterval = TimeSpan.FromDays(1);

        private const decimal MinPrice = 0.01m;

        private readonly StockRepository stockRepository = new StockRepository();
        private readonly PriceHistoryRepository historyRepository = new PriceHistoryRepository();
        private readonly Random random = new Random();

        private DateTime lastHistory = DateTime.MinValue;
        private DateTime lastCleanup = DateTime.MinValue;

        //runs every TickInterval while the app is open
        public void Tick()
        {
            DateTime now = DateTime.Now;
            bool recordHistory = now - lastHistory >= HistoryInterval;

            List<Stock> stocks = stockRepository.GetAll();
            var prices = new Dictionary<int, decimal>();
            var history = new List<PriceHistory>();

            foreach (Stock stock in stocks)
            {
                decimal price = ToPrice(Step((double)stock.CurrentPrice, (double)stock.Volatility));
                prices[stock.StockID] = price;

                if (recordHistory)
                    history.Add(new PriceHistory { StockID = stock.StockID, Price = price, RecordedAt = now });
            }

            stockRepository.SavePrices(prices, history);

            if (recordHistory)
                lastHistory = now;

            if (now - lastCleanup >= CleanupInterval)
                Cleanup(now);
        }

        private void Cleanup(DateTime now)
        {
            historyRepository.DeleteOlderThan(now - HistoryKept);
            lastCleanup = now;
        }

        //price * e^(sigma * z). sigma = volatility from one simulated day down to one tick
        private double Step(double price, double volatility)
        {
            double sigma = volatility * Math.Sqrt(TickInterval.TotalSeconds / SimulatedDay.TotalSeconds);
            return price * Math.Exp(sigma * NextChange());
        }

        //random number between -1.73 and 1.73
        private double NextChange()
        {
            return (random.NextDouble() * 2.0 - 1.0) * Math.Sqrt(3.0);
        }

        private static decimal ToPrice(double price)
        {
            return Math.Max(MinPrice, Math.Round((decimal)price, 2));
        }
    }
}
