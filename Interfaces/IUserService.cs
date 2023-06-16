using System.Threading.Tasks;
using ClassyAdsWinApp.Models;

namespace ClassyAdsWinApp.Interfaces
{
    internal interface IUserService
    {
        Task<User> Login(UserLoginInput loginInput);

        Task<User> Register(UserRegisterInput registerInput);

        void Logout();
    }
}
