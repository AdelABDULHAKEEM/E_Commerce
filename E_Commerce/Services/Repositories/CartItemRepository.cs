using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Services.Repositories
{
    public class CartItemRepository : ICartItem
    {
        private readonly E_CommerceDbContext _DbContext;

        public CartItemRepository(E_CommerceDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public int Count()
        {
            return _DbContext.CartItems.Count();
        }

        public void Delete(int id)
        {
            var CartItem = _DbContext.CartItems.FirstOrDefault(c => c.Id == id);
            if (CartItem != null)
            {
                _DbContext.CartItems.Remove(CartItem);
            }
        }

        public CartItem GetCartItem(int id)
        {
            var CartItem = _DbContext.CartItems.FirstOrDefault(c => c.Id == id);
            if (CartItem != null)
            {
                return CartItem;
            }
            return null;

        }

        public IEnumerable<CartItem> GetCartItems()
        {
            return _DbContext.CartItems;
        }

        public CartItem GetCartItems(int id)
        {
            var CartItem = _DbContext.CartItems.FirstOrDefault(c => c.Id == id);

            if (CartItem != null)
            {
                return CartItem;
            }
            return null;
        }

        public void Insert(CartItem cartItem)
        {
            _DbContext.CartItems.Add(cartItem);
        }

        public void Save()
        {
            _DbContext.SaveChanges();
        }

        public void Update(CartItem cartItem)
        {
            _DbContext.CartItems.Update(cartItem);
        }
    }
}
