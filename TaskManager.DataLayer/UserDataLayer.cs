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
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                return dbContext.Users.ToList();
            }
        }

        public User GetUserById(int userId)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                return dbContext.Users.Find(userId);
            }
        }

        public void AddUser(User user)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                dbContext.Entry(user).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public List<User> GetByUserName(string userName)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                return dbContext.Users.Where(a => a.FirstName.Contains(userName) || a.LastName.Contains(userName)).ToList();
            }
        }

        public void DeleteUser(int userId)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                var user = dbContext.Users.Find(userId);
                if (user != null) dbContext.Users.Remove(user);
                dbContext.SaveChanges();
            }
        }
    }
}
