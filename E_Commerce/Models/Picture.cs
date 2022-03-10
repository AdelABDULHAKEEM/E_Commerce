using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Picture
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string PictureFileName { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }

        //public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
        //public virtual Category Categories { get; set; } 

    }
}