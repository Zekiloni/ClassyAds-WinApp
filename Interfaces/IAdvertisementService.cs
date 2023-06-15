using ClassyAdsWinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyAdsWinApp.Interfaces
{
    internal interface IAdvertisementService
    {
        Task<IEnumerable<Advertisement>> GetAdvertisementListAsync();
    }
}
