using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Configuration;
using ClassyAdsWinApp.Interfaces;
using ClassyAdsWinApp.Models;
using System.Windows.Forms;
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

        public Task<User> Login(UserLoginInput loginInput)
        {
            throw new NotImplementedException();
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
    }
}
