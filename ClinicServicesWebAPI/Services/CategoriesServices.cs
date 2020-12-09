using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.DataConnect;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services 
{
    public class CategoriesServices : ICategories
    {
        private ClinicContext context;
        public CategoriesServices(ClinicContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Categories>> GetCategories()
        {
            return context.Categories.ToList();
        }

        public async Task<Categories> GetCategorie(int categoriesID)
        {
            Categories cate = context.Categories.SingleOrDefault(s => s.CategoriesID.Equals(categoriesID));
            if (cate != null)
            {
                return cate;
            }
            else
            { return null; }
        }

       

        public async Task<Categories> PostCategories(Categories categories)
        {
            context.Categories.Add(categories);
            context.SaveChanges();
            return categories;
        }

        public async Task<Categories> PutCategories(Categories categories)
        {
            Categories model = context.Categories.SingleOrDefault(s => s.CategoriesID.Equals(categories.CategoriesID));
            if (model != null)
            {
                model.CategoriesName = categories.CategoriesName;
                model.CategoriesDescription = categories.CategoriesDescription;
              
                context.SaveChanges();
                return categories;
            }
            else
            {
                return null;
            }
        }
        public async Task<Categories> DeleteCategorie(int categoriesID)
        {
            Categories cate = context.Categories.Where(n => n.CategoriesID.Equals(categoriesID)).FirstOrDefault();
            if (cate != null)
            {
                context.Categories.Remove(cate);
                context.SaveChanges();

            }
            else
            {
                //no thing 
            }
            return null;
        }
    }
    
}
