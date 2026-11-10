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
    }
}