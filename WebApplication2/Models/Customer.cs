using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Customer
    {
        [RegularExpression(@"^1\d{7}$",
          ErrorMessage = "An eight digit long number starting with 1 required")]
        public int CivilId { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public int Phone { get; set; }



    }
}
