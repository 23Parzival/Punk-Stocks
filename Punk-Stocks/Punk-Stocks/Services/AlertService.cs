using Punk_Stocks.Models.Enums;
using Punk_Stocks.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Punk_Stocks.Services
{
    //checks a user's price alerts against the current prices
    internal class AlertService
    {
        private readonly AlertRepository alertRepository = new AlertRepository();

        //marks every alert whose price was reached as triggered, and returns those alerts
        //only the logged in user's alerts are checked
        public List<Alert> Check(int userId)
        {
            using (var db = new PunkStocksDBEntities())
            {
                List<Alert> reached = alertRepository.GetWaiting(db, userId).Where(IsReached).ToList();
                if (reached.Count == 0)
                    return reached;

                foreach (Alert alert in reached)
                    alert.IsTriggered = true;

                db.SaveChanges();
                return reached;
            }
        }

        public static bool IsReached(Alert alert)
        {
            decimal price = alert.Stock.CurrentPrice;
            if (alert.Direction == (int)AlertDirection.Above)
                return price >= alert.TargetPrice;
            return price <= alert.TargetPrice;
        }

        public static string Describe(Alert alert)
        {
            string key = alert.Direction == (int)AlertDirection.Above ? "Alert_WentAbove" : "Alert_WentBelow";
            return LanguageManager.Format(key, alert.Stock.Symbol, alert.TargetPrice.ToString("C2"), alert.Stock.CurrentPrice.ToString("C2"));
        }
    }
}
