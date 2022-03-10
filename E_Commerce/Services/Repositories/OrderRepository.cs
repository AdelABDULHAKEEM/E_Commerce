using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repositories
{
    public class OrderRepository :IOrder
    {
        private readonly E_CommerceDbContext _DbContext;

        public OrderRepository(E_CommerceDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public int Count()
        {
            return _DbContext.Orders.Count();
        }

        public void Delete(int id)
        {
            var Order = _DbContext.Orders.FirstOrDefault(c => c.Id == id);
            if (Order != null)
            {
                _DbContext.Orders.Remove(Order);
            }
        }


        public Order GetOder(int id)
        {
            var Order = _DbContext.Orders.FirstOrDefault(c => c.Id == id);

            if (Order != null)
            {
                return Order;
            }
            return null;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _DbContext.Orders;
        }

        public void Insert(Order order)
        {
            _DbContext.Orders.Add(order);
        }

        public void Save()
        {
            _DbContext.SaveChanges();
        }

        public void Update(Order order)
        {
            _DbContext.Orders.Update(order);
        }
    }
}
