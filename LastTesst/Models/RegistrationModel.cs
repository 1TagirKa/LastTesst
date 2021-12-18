using System.ComponentModel.DataAnnotations;

namespace LastTesst.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Enter your name")]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Enter your username")]
        [StringLength(50)]
        [Display(Name = "Username")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Enter your phone")]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        
        [Required]
        [StringLength(15,MinimumLength = 6)]
        [Display(Name = "Password")]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }
        
        [Required]
        [StringLength(15, MinimumLength = 6)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}