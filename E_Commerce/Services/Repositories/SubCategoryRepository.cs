using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repositories
{
    public class SubCategoryRepository : ISubCategory
    {
        private readonly E_CommerceDbContext _DbContext;

        public SubCategoryRepository(E_CommerceDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public int Count()
        {
            return _DbContext.SubCategories.Count();
        }

        public void Delete(int id)
        {
            var SubCategory = _DbContext.SubCategories.FirstOrDefault(c => c.Id == id);
            if (SubCategory != null)
            {
                _DbContext.SubCategories.Remove(SubCategory);
            }
        }

        public SubCategory GetSubCategory(int id)
        {
            var SubCategory = _DbContext.SubCategories.FirstOrDefault(c => c.Id == id);
            if (SubCategory != null)
            {
                return SubCategory;
            }
            return null;

        }

        public IEnumerable<SubCategory> GetSubCategories()
        {
            return _DbContext.SubCategories;
        }

        public void Insert(SubCategory subCategory)
        {
            _DbContext.SubCategories.Add(subCategory);
        }

        public void Save()
        {
            _DbContext.SaveChanges();
        }

        public void Update(SubCategory subCategory)
        {
            _DbContext.SubCategories.Update(subCategory);
        }
    }
}
