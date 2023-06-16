using ClassyAdsWinApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassyAdsWinApp.Interfaces
{
    internal interface IAdvertisementService
    {
        Task<IEnumerable<Advertisement>> GetAdvertisementListAsync();
    }
}
