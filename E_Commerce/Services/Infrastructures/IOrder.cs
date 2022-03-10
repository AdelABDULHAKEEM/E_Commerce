using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repository
{
     public interface IOrder
    {
        IEnumerable<Order> GetOrders();
        Order GetOder(int id);
        void Delete(int id);
        int Count();
        void Save();
    }
}
