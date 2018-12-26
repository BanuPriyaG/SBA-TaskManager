using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DataLayer;

namespace TaskManager.BusinessLayer
{
    public static class Users
    {
        public static List<User> GetAllUsers()
        {
            UserDataLayer dataLayer = new UserDataLayer();
            return dataLayer.GetUsersList();
        }

        public static User GetUserById(int userId)
        {
            UserDataLayer dataLayer = new UserDataLayer();
            return dataLayer.GetUserById(userId);
        }

        public static void AddUser(User user)
        {
            UserDataLayer dataLayer = new UserDataLayer();
            dataLayer.AddUser(user);
        }

        public static void UpdateUser(User user)
        {
            UserDataLayer dataLayer = new UserDataLayer();
            dataLayer.UpdateUser(user);
        }

        public static List<User> GetByUserName(string userName)
        {
            UserDataLayer dataLayer = new UserDataLayer();
            return dataLayer.GetByUserName(userName);
        }

        public static void DeleteUser(int userId)
        {
            UserDataLayer dataLayer = new UserDataLayer();
            dataLayer.DeleteUser(userId);
        }
    }
}
