using ClassyAdsWinApp.Interfaces;
using ClassyAdsWinApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClassyAdsWinApp.Services
{
    internal class AdvertisementService : IAdvertisementService
    {
        private readonly HttpClient httpClient;

        public AdvertisementService() {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerApiEndpoint"])
            };
        }

        public Task<IEnumerable<Advertisement>> GetAdvertisementListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
