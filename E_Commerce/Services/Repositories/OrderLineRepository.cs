using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repositories
{
    public class OrderLineRepository : IOrderLine
    {
        private readonly E_CommerceDbContext _DbContext;

        public OrderLineRepository(E_CommerceDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public int Count()
        {
            return _DbContext.OrderLines.Count();
        }

        public void Delete(int id)
        {
            var OrderLine = _DbContext.OrderLines.FirstOrDefault(c => c.Id == id);
            if (OrderLine != null)
            {
                _DbContext.OrderLines.Remove(OrderLine);
            }
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            return _DbContext.OrderLines;
        }

        public OrderLine GetOrderLine(int id)
        {
            var OrderLine = _DbContext.OrderLines.FirstOrDefault(c => c.Id == id);

            if (OrderLine != null)
            {
                return OrderLine;
            }
            return null;
        }

        public void Insert(OrderLine orderLine)
        {
            _DbContext.OrderLines.Add(orderLine);
        }


        public void Update(OrderLine orderLine)
        {
            _DbContext.OrderLines.Update(orderLine);
        }

        public void Save()
        {
            _DbContext.SaveChanges();
        }
    }
}
