using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repository
{
    public  interface IOrderLine
    {
        IEnumerable<OrderLine> GetOrderLines();
        OrderLine GetOrderLine(int id);
        void Insert(OrderLine orderLine);
        void Update(OrderLine orderLine);
        int Count();
        void Save();
    }
}
