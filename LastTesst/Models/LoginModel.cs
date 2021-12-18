using System.ComponentModel.DataAnnotations;
namespace LastTesst.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(15,MinimumLength = 6)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}