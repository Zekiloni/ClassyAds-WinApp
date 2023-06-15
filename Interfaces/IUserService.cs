using ClassyAdsWinApp.Models;
using System;
using System.Threading.Tasks;

namespace ClassyAdsWinApp.Interfaces
{
    internal interface IUserService
    {
        Task<User> Login(UserLoginInput loginInput);

        Task<User> Register(UserRegisterInput registerInput);
    }
}
