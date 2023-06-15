using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyAdsWinApp.Models
{
    internal class UserSession
    {
        private static UserSession instance;

        public User User { get; private set; }

        public string Token { get; private set; }

        private UserSession()
        {
        }

        public static UserSession Active
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserSession();
                }
                return instance;
            }
        }

        public void SetUser(User user, string token)
        {
            User = user;
            Token = token;
        }

        public void ClearUser()
        {
            User = null;
            Token = null;
        }
    }
}
