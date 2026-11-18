using Punk_Stocks.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Punk_Stocks.Services
{
    //moves every stock price on a timer, and catches up the time the app was closed
    internal class PriceSimulator
    {
        public static readonly TimeSpan TickInterval = TimeSpan.FromSeconds(10);

        //one real hour counts as one simulated day
        private static readonly TimeSpan SimulatedDay = TimeSpan.FromHours(1);

        //small upward trend so the market grows over time. 0.08 = about 8% growth per simulated year of 252 trading days
        private const double YearlyTrend = 0.08;
        private const double TradingDaysPerYear = 252;

        //history is saved less often than prices change to keep the table small
        private static readonly TimeSpan HistoryInterval = TimeSpan.FromMinutes(5);
        private static readonly TimeSpan CatchUpHistoryInterval = TimeSpan.FromHours(1);

        private static readonly TimeSpan MaxCatchUp = TimeSpan.FromDays(10);
        private static readonly TimeSpan HistoryKept = TimeSpan.FromDays(30);
        private static readonly TimeSpan CleanupInterval = TimeSpan.FromDays(1);

        private const decimal MinPrice = 0.01m;

        private readonly StockRepository stockRepository = new StockRepository();
        private readonly PriceHistoryRepository historyRepository = new PriceHistoryRepository();
        private readonly Random random = new Random();

        private DateTime lastHistory = DateTime.MinValue;
        private DateTime lastCleanup = DateTime.MinValue;

        //replays the ticks missed while the app was closed (up to MaxCatchUp)
        public void CatchUp()
        {
            DateTime now = DateTime.Now;
            DateTime? lastRecorded = historyRepository.GetLastRecorded();

            if (lastRecorded.HasValue)
            {
                DateTime start = lastRecorded.Value > now - MaxCatchUp ? lastRecorded.Value : now - MaxCatchUp;
                long tickCount = (now - start).Ticks / TickInterval.Ticks;

                if (tickCount > 0)
                    Simulate(start, tickCount, CatchUpHistoryInterval);
            }

            lastHistory = now;
            Cleanup(now);
        }

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

        private void Simulate(DateTime start, long tickCount, TimeSpan historyInterval)
        {
            List<Stock> stocks = stockRepository.GetAll();

            //kept as double between ticks so small moves are not lost to rounding
            Dictionary<int, double> prices = stocks.ToDictionary(s => s.StockID, s => (double)s.CurrentPrice);
            var history = new List<PriceHistory>();
            DateTime nextHistory = start + historyInterval;

            for (long i = 1; i <= tickCount; i++)
            {
                DateTime time = start + TimeSpan.FromTicks(TickInterval.Ticks * i);

                foreach (Stock stock in stocks)
                    prices[stock.StockID] = Math.Max((double)MinPrice, Step(prices[stock.StockID], (double)stock.Volatility));

                //a history point every historyInterval, and always one at the end
                if (time >= nextHistory || i == tickCount)
                {
                    foreach (Stock stock in stocks)
                        history.Add(new PriceHistory { StockID = stock.StockID, Price = ToPrice(prices[stock.StockID]), RecordedAt = time });

                    nextHistory = time + historyInterval;
                }
            }

            stockRepository.SavePrices(prices.ToDictionary(p => p.Key, p => ToPrice(p.Value)), history);
        }

        private void Cleanup(DateTime now)
        {
            historyRepository.DeleteOlderThan(now - HistoryKept);
            lastCleanup = now;
        }

        //price * e^(trend + sigma * z). trend and sigma are both from one simulated day down to one tick
        private double Step(double price, double volatility)
        {
            double daysPerTick = TickInterval.TotalSeconds / SimulatedDay.TotalSeconds;
            double trend = Math.Log(1.0 + YearlyTrend) / TradingDaysPerYear * daysPerTick;
            double sigma = volatility * Math.Sqrt(daysPerTick);
            return price * Math.Exp(trend + sigma * NextChange());
        }

        //random number between -1.73 and 1.73
        //sqrt(3) makes it -1..1 so the average move size matches the volatility
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
