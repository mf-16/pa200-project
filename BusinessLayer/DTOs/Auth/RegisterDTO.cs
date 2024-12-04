using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.Auth;

public class RegisterDTO
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters.")]
    public string Name { get; set; }
    
    
    [Required(ErrorMessage = "Username is required.")]
    [StringLength(50, ErrorMessage = "Username can't be longer than 50 characters.")]
    public string UserName { get; set; }
    

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [StringLength(
        100,
        MinimumLength = 3,
        ErrorMessage = "Password must be at least 3 characters long."
    )]
    public string Password { get; set; }
}