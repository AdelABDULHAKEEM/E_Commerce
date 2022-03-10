using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repository
{
     public interface IProduct
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void Insert(Product product);
        void Update(Product product);
        void Delete(int id);
        int Count();
        void Save();
    }
}
