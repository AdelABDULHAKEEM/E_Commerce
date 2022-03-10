using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repository
{
    public interface ISubCategory
    {
        IEnumerable<SubCategory> GetSubCategories();
        SubCategory GetSubCategory(int id);
        void Insert(SubCategory product);
        void Update(SubCategory product);
        void Delete(int id);
        int Count();
        void Save();
    }
}
