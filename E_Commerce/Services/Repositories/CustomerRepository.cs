using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repositories
{
    public class CustomerRepository : ICustomer
    {
        private readonly E_CommerceDbContext _DbContext;

        public CustomerRepository(E_CommerceDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public int Count()
        {
            return _DbContext.Customers.Count();
        }

        public void Delete(string name)
        {
            var Customer = _DbContext.Customers.FirstOrDefault(c => c.Name == name);
            if (Customer != null)
            {
                _DbContext.Customers.Remove(Customer);
            }
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _DbContext.Customers;
        }

        public Customer GetCustomer(string name)
        {
            var Customer = _DbContext.Customers.FirstOrDefault(c => c.Name == name);

            if (Customer != null)
            {
                return Customer;
            }
            return null;
        }

        public void Insert(Customer customer)
        {
            _DbContext.Customers.Add(customer);
        }

        public void Save()
        {
            _DbContext.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _DbContext.Customers.Update(customer);
        }
    }
}
