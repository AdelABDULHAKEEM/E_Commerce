using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Customer : IdentityUser
    {
       
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? EnteredDate { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}