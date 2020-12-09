using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
   public interface ICategoryChild
    {
        Task<IEnumerable<CategoryChild>> GetCategoryChilds();
        Task<CategoryChild> GetCategoryChild(int cateChildID);
        Task<CategoryChild> PostCategoryChilds(CategoryChild categoryChild);
        Task<CategoryChild> PutCategoryChilds(CategoryChild categoryChild);
        Task<CategoryChild> DeleteCategoryChild(int cateChildID);
    }
}
