using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="Length of name can be only 50 characters")]
        public string Name { get; set; }
        public string NationalId { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
