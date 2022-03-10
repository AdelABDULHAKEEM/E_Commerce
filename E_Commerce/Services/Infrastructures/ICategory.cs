using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repoistory
{
   public interface ICategory
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(int id);
        void Insert(Category category);
        void Update(Category category);
        void Delete(int id);
        int Count();

    }
}
