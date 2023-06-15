
using System;

namespace ClassyAdsWinApp.Models
{
    internal class UserLoginInput
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }


    internal class UserRegisterInput
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
