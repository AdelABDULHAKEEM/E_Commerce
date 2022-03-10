using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repositories
{
    public class ProductRepository : IProduct
    {
        private readonly E_CommerceDbContext _DbContext;

        public ProductRepository(E_CommerceDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public int Count()
        {
            return _DbContext.Products.Count();
        }

        public void Delete(int id)
        {
            var Product = _DbContext.Products.FirstOrDefault(c => c.Id == id);
            if (Product != null)
            {
                _DbContext.Products.Remove(Product);
            }
        }

        public Product GetProduct(int id)
        {
            var Product = _DbContext.Products.FirstOrDefault(c => c.Id == id);
            if (Product != null)
            {
                return Product;
            }
            return null;
        }


        public IEnumerable<Product> GetProducts()
        {
            return _DbContext.Products;
        }

        public void Insert(Product product)
        {
            _DbContext.Products.Add(product);
        }

        public void Save()
        {
            _DbContext.SaveChanges();
        }

        public void Update(Product product)
        {
            _DbContext.Products.Update(product);
        }
    }
}
