using ClassyAdsWinApp.Interfaces;
using ClassyAdsWinApp.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClassyAdsWinApp.Services
{
    internal class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<bool> Login(UserLoginInput userLoginInput)
        {
            try
            {
                var response = await _httpClient.PostAsync("login", userLoginInput);

                // If the request is successful (status code 200), deserialize the response content into a User object
                if (response.IsSuccessStatusCode)
                {
                    var user = await response.Content.ReadAsAsync<User>();
                    return user;
                }
                else
                {
                    // Handle the error response or throw an exception
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Login failed: {errorMessage}");
                }

            } catch (Exception ex)
            {
                throw new Exception("An error occurred while logging in.", ex);
            }
        }
    }
}
