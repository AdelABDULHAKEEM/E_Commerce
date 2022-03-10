using E_Commerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.ViewModels.Account;

namespace E_Commerce.Data
{
    public class E_CommerceDbContext : IdentityDbContext<Customer>
    {
       
        public E_CommerceDbContext(DbContextOptions<E_CommerceDbContext> options) : base(options)
        {
           
        }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<RegisterViewModel> RegisterViewModel { get; set; }
        public DbSet<LoginViewModel> LoginViewModel { get; set; }

    }
}
