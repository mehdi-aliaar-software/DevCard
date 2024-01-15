using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "this data must be applied")]
        [MinLength(3, ErrorMessage = "at least 3 characters")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "this data must be applied")]
        [EmailAddress(ErrorMessage = "a correct email format must be applied")]
        public string Email { get; set; }
        public string Message { get; set; }
        public int Service { get; set; }
        public SelectList Services { get; set; }
    }
}
