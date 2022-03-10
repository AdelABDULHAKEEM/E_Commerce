using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Services.Repoistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repositories
{
    public class CategoryRepository : ICategory
    {
        private readonly E_CommerceDbContext _DbContext;

        public CategoryRepository(E_CommerceDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public int Count()
        {
            return _DbContext.Categories.Count();
        }

        public void Delete(int id)
        {
            var category = _DbContext.Categories.FirstOrDefault(c => c.Id == id);
            if(category != null)
            {
                _DbContext.Categories.Remove(category);
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return _DbContext.Categories;
        }

        public Category GetCategory(int id)
        {
            var category = _DbContext.Categories.FirstOrDefault(c => c.Id == id);
          
            if (category != null)
            {
                return category;
            }
            return null;
        }

        public void Insert(Category category)
        {
            _DbContext.Categories.Add(category);
        }


        public void Update(Category category)
        {
            _DbContext.Categories.Update(category);
        }
    }
}
