using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;
using ClinicServicesWebAPI.Services;

namespace ClinicServicesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryChildsController : ControllerBase
    {
        private ICategoryChild icatechild;
        public CategoryChildsController(ICategoryChild icatechild)
        {
            this.icatechild = icatechild;
        }
        [HttpGet()]
        public async Task<IEnumerable<CategoryChild>> GetCategoryChilds()
        {
            return await icatechild.GetCategoryChilds();
        }
        [HttpGet("{cateChildID}")]
        public async Task<CategoryChild> GetCategoryChild(int cateChildID)
        {
            return await icatechild.GetCategoryChild(cateChildID);
        }
        [HttpPost()]
        public async Task<CategoryChild> PostCategoryChilds(CategoryChild categoryChild)
        {
            return await icatechild.PostCategoryChilds(categoryChild);
        }
        [HttpPut()]
        public async Task<CategoryChild> PutCategoryChilds(CategoryChild categoryChild)
        {
            return await icatechild.PutCategoryChilds(categoryChild);
        }
        [HttpDelete("{cateChildID}")]
        public async Task<CategoryChild> DeleteCategoryChild(int cateChildID)
        {
            return await icatechild.DeleteCategoryChild(cateChildID);
        }
    }
}
