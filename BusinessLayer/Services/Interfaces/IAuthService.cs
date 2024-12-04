using BusinessLayer.DTOs.Auth;
using BusinessLayer.DTOs.User;
using Microsoft.AspNetCore.Identity;

namespace BusinessLayer.Services.Interfaces;

public interface IAuthService
{
    Task<IdentityResult> RegisterAsync(RegisterDTO registerDto);
    Task<SignInResult> LoginAsync(LoginDTO loginDto);
    Task LogoutAsync();
}