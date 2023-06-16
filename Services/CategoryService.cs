using ClassyAdsWinApp.Interfaces;
using ClassyAdsWinApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassyAdsWinApp.Services
{
    internal class CategoryService : ICategoryService
    {
        private readonly HttpClient httpClient;

        public CategoryService() {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerApiEndpoint"])
            };
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            var response = await httpClient.GetAsync("/categories");

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var categories = JsonConvert.DeserializeObject<IEnumerable<Category>>(responseContent);
                return categories;
            }
            else
            {
                return null;
            }
        }
    }
}
