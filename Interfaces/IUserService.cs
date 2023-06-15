using ClassyAdsWinApp.Models;
using System;
using System.Threading.Tasks;

namespace ClassyAdsWinApp.Interfaces
{
    internal interface IUserService
    {
        Task<Boolean> Login(UserLoginInput userLoginInput);
    }
}
