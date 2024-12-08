using BusinessLayer.DTOs.User;
using Microsoft.AspNetCore.Identity;

namespace BusinessLayer.Services.Interfaces;

public interface IUserService
{
    Task<ResponseUserDto> CreateUserAsync(CreateUserDto dto);
    Task<ResponseUserDto> UpdateUserAsync(int id, UpdateUserDto dto);
    Task DeleteUserAsync(int id);
    Task<ResponseUserDto> GetUserAsync(int id);
    Task<List<ResponseUserDto>> GetAllUsersAsync();
    Task<IdentityResult> ResetPasswordAsync(int id, string newPassword);
}
