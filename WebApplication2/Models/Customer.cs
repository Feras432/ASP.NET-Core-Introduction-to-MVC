using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Customer
    {
        [Required]
        public int CivilId { get; set; }
        
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int Phone { get; set; }



    }
}
