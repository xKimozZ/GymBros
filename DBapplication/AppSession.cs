using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBapplication
{
    internal class AppSession
    {
        public static int UserId { get; private set; }
        public static string UserName { get; private set; }
        public static bool IsLoggedIn { get; private set; }

        public static void Login(int userId , string userName)
        {
            UserId = userId;
            UserName = userName;
            IsLoggedIn = true;
        }

        public static void Logout()
        {
            UserId = 0;
            UserName = null;
            IsLoggedIn = false;
        }
    }
}
