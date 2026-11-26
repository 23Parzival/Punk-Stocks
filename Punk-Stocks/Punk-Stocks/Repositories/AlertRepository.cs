using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Punk_Stocks.Repositories
{
    internal class AlertRepository
    {
        public List<Alert> GetForUser(int userId)
        {
            using (var db = new PunkStocksDBEntities())
            {
                return db.Alerts.AsNoTracking()
                    .Include(a => a.Stock)
                    .Where(a => a.UserID == userId)
                    .OrderBy(a => a.Stock.Symbol)
                    .ThenBy(a => a.TargetPrice)
                    .ToList();
            }
        }

        public void Add(Alert alert)
        {
            using (var db = new PunkStocksDBEntities())
            {
                db.Alerts.Add(alert);
                db.SaveChanges();
            }
        }

        //userId too, that way one user can't remove another user's alert
        public void Remove(int alertId, int userId)
        {
            using (var db = new PunkStocksDBEntities())
            {
                Alert alert = db.Alerts.FirstOrDefault(a => a.AlertID == alertId && a.UserID == userId);
                if (alert == null)
                    return;

                db.Alerts.Remove(alert);
                db.SaveChanges();
            }
        }

        //takes the caller's db so the check is saved in one SaveChanges
        public List<Alert> GetWaiting(PunkStocksDBEntities db, int userId)
        {
            return db.Alerts.Include(a => a.Stock)
                .Where(a => a.UserID == userId && !a.IsTriggered)
                .ToList();
        }
    }
}
