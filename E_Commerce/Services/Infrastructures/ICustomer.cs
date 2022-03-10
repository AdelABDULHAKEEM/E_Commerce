using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repository
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(string name);
        void Insert(Customer customer);
        void Update(Customer customer);
        void Delete(string name);
        int Count();
        void Save();

    }
}
