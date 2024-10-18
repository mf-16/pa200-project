using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.User;

public class UpdateUserDto
{
    [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters.")]
    public string? Name { get; set; }

    [StringLength(50, ErrorMessage = "Username can't be longer than 50 characters.")]
    public string? UserName { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string? Email { get; set; }

    [StringLength(
        100,
        MinimumLength = 3,
        ErrorMessage = "Password must be at least 3 characters long."
    )]
    public string? Password { get; set; }

    [Phone(ErrorMessage = "Invalid phone number format.")]
    public string? PhoneNumber { get; set; }
}
