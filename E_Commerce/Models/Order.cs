using System;
using System.Collections.Generic;

namespace E_Commerce.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOfOrder { get; set; }
        public decimal TotalOrder { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
     
    }
}