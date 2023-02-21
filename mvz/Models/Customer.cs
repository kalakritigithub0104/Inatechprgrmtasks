using System.ComponentModel.DataAnnotations;
namespace KoreMvz.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string? CustomerName { get; set; }
        public string ?Gender { get; set; }
        public string ?City { get; set; }
        public string ?ContactNo { get; set; }
    }
}
