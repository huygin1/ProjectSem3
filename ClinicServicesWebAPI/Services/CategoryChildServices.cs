using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.DataConnect;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
    public class CategoryChildServices : ICategoryChild
    {
        private ClinicContext context;
        public CategoryChildServices(ClinicContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<CategoryChild>> GetCategoryChilds()
        {
            return context.CategoryChild.ToList();
        }


        public async Task<CategoryChild> GetCategoryChild(int cateChildID)
        {
            CategoryChild cc = context.CategoryChild.SingleOrDefault(s => s.CategoryChild_ID.Equals(cateChildID));
            if (cc != null)
            {
                return cc;
            }
            else
            { return null; }
        }

       
        public async Task<CategoryChild> PostCategoryChilds(CategoryChild categoryChild)
        {
            context.CategoryChild.Add(categoryChild);
            context.SaveChanges();
            return categoryChild;
        }

        public async Task<CategoryChild> PutCategoryChilds(CategoryChild categoryChild)
        {
            CategoryChild model = context.CategoryChild.SingleOrDefault(s => s.CategoryChild_ID.Equals(categoryChild.CategoryChild_ID));
            if (model != null)
            {
                model.CateChild_Name = categoryChild.CateChild_Name;
                model.CateChild_Description = categoryChild.CateChild_Description;
               
                context.SaveChanges();
                return categoryChild;
            }
            else
            {
                return null;
            }
        }
        public async Task<CategoryChild> DeleteCategoryChild(int cateChildID)
        {
            CategoryChild ca = context.CategoryChild.Where(n => n.CategoryChild_ID.Equals(cateChildID)).FirstOrDefault();
            if (ca != null)
            {
                context.CategoryChild.Remove(ca);
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
