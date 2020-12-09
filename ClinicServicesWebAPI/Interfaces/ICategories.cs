using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;
namespace ClinicServicesWebAPI.Services
{
   public interface ICategories
    {
        Task<IEnumerable<Categories>> GetCategories();
        Task<Categories> GetCategorie(int categoriesID);
        Task<Categories> PostCategories(Categories categories);
        Task<Categories> PutCategories(Categories categories);
        Task<Categories> DeleteCategorie(int categoriesID);
    }
}
