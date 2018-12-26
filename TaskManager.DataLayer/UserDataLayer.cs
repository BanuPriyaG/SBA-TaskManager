using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DataLayer
{
    public class UserDataLayer
    {
        public List<User> GetUsersList()
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                return dbContext.Users.ToList();
            }
        }

        public User GetUserById(int userId)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                return dbContext.Users.Find(userId);
            }
        }

        public void AddUser(User user)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                dbContext.Entry(user).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public List<User> GetByUserName(string userName)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                return dbContext.Users.Where(a => a.FirstName.Contains(userName) || a.LastName.Contains(userName)).ToList();
            }
        }

        public void DeleteUser(int userId)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                var user = dbContext.Users.Find(userId);
                if (user != null) dbContext.Users.Remove(user);
                dbContext.SaveChanges();
            }
        }
    }
}
