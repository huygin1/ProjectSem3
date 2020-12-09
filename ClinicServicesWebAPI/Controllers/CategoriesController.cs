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
    public class CategoriesController : ControllerBase
    {
        private ICategories icategories;
        public CategoriesController(ICategories icategories)
        {
            this.icategories = icategories;
        }
        [HttpGet()]
        public async Task<IEnumerable<Categories>> GetCategories()
        {
            return await icategories.GetCategories();
        }
        [HttpGet("{categoriesID}")]
        public async Task<Categories> GetCategorie(int categoriesID)
        {
            return await icategories.GetCategorie(categoriesID);
        }
        [HttpPost()]
        public async Task<Categories> PostCategories(Categories categories)
        {
            return await icategories.PostCategories(categories);
        }
        [HttpPut()]
        public async Task<Categories> PutCategories(Categories categories)
        {
            return await icategories.PutCategories(categories);
        }
        [HttpDelete("{categoriesID}")]
        public async Task<Categories> DeleteCategorie(int categoriesID)
        {
            return await icategories.DeleteCategorie(categoriesID);
        }
    }
}
