using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Configuration;
using ClassyAdsWinApp.Interfaces;
using ClassyAdsWinApp.Models;
using Newtonsoft.Json;
using System.Text;

namespace ClassyAdsWinApp.Services
{
    internal class UserService : IUserService
    {
        private readonly HttpClient httpClient;

        public UserService()
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerApiEndpoint"])
            };
        }

        public async Task<User> Login(UserLoginInput loginInput)
        {
            var json = JsonConvert.SerializeObject(loginInput);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("/users/login", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var loginSession = JsonConvert.DeserializeObject<LoginSuccessOutput>(responseContent);

                UserSession.Active.SetUser(loginSession.User, loginSession.Token);
                return null;
            } else
            {
                return null;
            }
        }

        public async Task<User> Register(UserRegisterInput registerInput)
        {
            var json = JsonConvert.SerializeObject(registerInput);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("/users/register", content);

            if (response.IsSuccessStatusCode) {
                var responseContent = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<User>(responseContent);
                return user;
            } else
            {
                return null;
            }
        }

        public async Task Logout()
        {
            UserSession.Active.ClearUser();
        }
    }
}
