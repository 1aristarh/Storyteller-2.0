using System.ComponentModel.DataAnnotations;

namespace Storyteller_2._0.Data.VModels
{
    public class RegisterVM
    {
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[!@#$%^&*()_+])(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$",
        ErrorMessage = "The password must contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]

        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        
        public string ConfirmPassword { get; set; }
    }
}
