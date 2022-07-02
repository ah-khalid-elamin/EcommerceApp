using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        
        public string Name { get; set; }
        public decimal Price  { get; set; }
        public DateTime DateGreated { get; set; }
    }
}
