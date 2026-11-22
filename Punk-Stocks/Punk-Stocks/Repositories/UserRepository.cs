using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Punk_Stocks.Repositories
{
    internal class UserRepository
    {
        public User GetByUsername(string username)
        {
            using (var db = new PunkStocksDBEntities())
            {
                return db.Users.AsNoTracking().FirstOrDefault(u => u.Username == username);
            }
        }

        public bool UsernameExists(string username)
        {
            using (var db = new PunkStocksDBEntities())
            {
                return db.Users.Any(u => u.Username == username);
            }
        }

        public User Add(User user)
        {
            using (var db = new PunkStocksDBEntities())
            {
                db.Users.Add(user);
                db.SaveChanges();
                return user;
            }
        }

        public void UpdateLanguage(int userId, int language)
        {
            using (var db = new PunkStocksDBEntities())
            {
                User user = db.Users.Find(userId);
                if (user == null)
                    return;

                user.Language = language;
                db.SaveChanges();
            }
        }

        public User GetById(int userId)
        {
            using (var db = new PunkStocksDBEntities())
            {
                return db.Users.AsNoTracking().FirstOrDefault(u => u.UserID == userId);
            }
        }

        public void UpdateUsername(int userId, string username)
        {
            using (var db = new PunkStocksDBEntities())
            {
                User user = db.Users.Find(userId);
                if (user == null)
                    return;

                user.Username = username;
                db.SaveChanges();
            }
        }

        public void UpdatePassword(int userId, string passwordHash)
        {
            using (var db = new PunkStocksDBEntities())
            {
                User user = db.Users.Find(userId);
                if (user == null)
                    return;

                user.PasswordHash = passwordHash;
                db.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            using (var db = new PunkStocksDBEntities())
            {
                return db.Users.AsNoTracking().OrderBy(u => u.UserID).ToList();
            }
        }

        //deletes everything the user owns and gives back their starting cash. returns the new cash, or null if the user is gone
        public decimal? ResetAccount(int userId)
        {
            using (var db = new PunkStocksDBEntities())
            {
                User user = db.Users.Find(userId);
                if (user == null)
                    return null;

                db.Transactions.RemoveRange(db.Transactions.Where(t => t.UserID == userId));
                db.Dividends.RemoveRange(db.Dividends.Where(d => d.UserID == userId));
                db.Holdings.RemoveRange(db.Holdings.Where(h => h.UserID == userId));
                db.WatchlistItems.RemoveRange(db.WatchlistItems.Where(w => w.UserID == userId));
                db.Alerts.RemoveRange(db.Alerts.Where(a => a.UserID == userId));

                user.CashBalance = user.StartingCash;
                db.SaveChanges();
                return user.StartingCash;
            }
        }

        //the database deletes the user (cascade)
        public void Delete(int userId)
        {
            using (var db = new PunkStocksDBEntities())
            {
                User user = db.Users.Find(userId);
                if (user == null)
                    return;

                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        public User Find(PunkStocksDBEntities db, int userId)
        {
            return db.Users.Find(userId);
        }
    }
}