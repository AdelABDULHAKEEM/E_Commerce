using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoeyName { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public virtual ICollection<SubCategory> SubCategories { get; set; } = new HashSet<SubCategory>();




    }
}
