using System.ComponentModel.DataAnnotations;

namespace Application_02.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage = "First Name is too long.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, ErrorMessage = "Last Name is too long.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email Address is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email format (e.g., user@example.com).")]
        public string Email { get; set; } = string.Empty;
    }
}