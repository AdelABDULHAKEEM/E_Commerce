using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repository
{
    public interface ICartItem
    {
        IEnumerable<CartItem> GetCartItems();
        CartItem GetCartItem(int id);
        void Insert(CartItem cartItem);
        void Update(CartItem cartItem);
        void Delete(int id);
        int Count();
        void Save();
    }
}
