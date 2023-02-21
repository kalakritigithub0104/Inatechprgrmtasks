using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KoreMvz.Models
{
    public class Membership
    {
        [Key]
        public int MemId { get; set; }
        [ForeignKey("Customer")]
        public int ? CustomerId { get; set; }
        public Customer Customer { get; set; }
        
        public int MembershipTypeId { get; set; }
        
    }
}
