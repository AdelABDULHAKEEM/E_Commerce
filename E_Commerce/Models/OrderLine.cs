using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        [Range(1,100,ErrorMessage = "Price Must be between {0} and {1}")]
        public decimal? Price { get; set; }
        public int OrderId { get; set; }
        public int? ProductId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}