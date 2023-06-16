
using ClassyAdsWinApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassyAdsWinApp.Interfaces
{
    internal interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategories();
    }
}
