using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "this data must be applied")]
        [MinLength(3, ErrorMessage= "at least 3 characters")]
        [MaxLength(50)]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "a correct email format must be applied")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }
    }
}
