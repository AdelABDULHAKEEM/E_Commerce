using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        [Display(Name ="SubCategory Name")]
        public string SubCategoeyName { get; set; }
        public virtual Category Category { get; set; }
      

    }
}