using AutoMapper;
using BusinessLayer.DTOs.Auth;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Identity;

namespace BusinessLayer.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly RoleManager<UserRole> _roleManager;
    private readonly IMapper _mapper;

    public AuthService(
        UserManager<User> userManager,
        SignInManager<User> signInManager,
        IMapper mapper,
        RoleManager<UserRole> roleManager
    )
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _mapper = mapper;
        _roleManager = roleManager;
    }

    public async Task<IdentityResult> RegisterAsync(RegisterDTO registerDto)
    {
        var user = _mapper.Map<RegisterDTO, User>(registerDto);

        var result = await _userManager.CreateAsync(user, registerDto.Password);

        if (result.Succeeded)
        {
            if (registerDto.IsAdmin)
            {
                var adminRoleExists = await _roleManager.RoleExistsAsync("Admin");
                if (!adminRoleExists)
                {
                    await _roleManager.CreateAsync(new UserRole() { Name = "Admin" });
                }

                await _userManager.AddToRoleAsync(user, "Admin");
            }
            else
            {
                var userRoleExists = await _roleManager.RoleExistsAsync("User");
                if (!userRoleExists)
                {
                    await _roleManager.CreateAsync(new UserRole() { Name = "User" });
                }

                await _userManager.AddToRoleAsync(user, "User");
            }
        }

        return result;
    }

    public async Task<SignInResult> LoginAsync(LoginDTO loginDto)
    {
        return await _signInManager.PasswordSignInAsync(
            loginDto.Email,
            loginDto.Password,
            false,
            false
        );
    }

    public async Task LogoutAsync()
    {
        await _signInManager.SignOutAsync();
    }
}
