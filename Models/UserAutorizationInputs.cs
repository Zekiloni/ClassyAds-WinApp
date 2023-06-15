

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
    }
}
