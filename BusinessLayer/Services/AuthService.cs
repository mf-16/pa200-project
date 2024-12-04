using AutoMapper;
using BusinessLayer.DTOs.Auth;
using BusinessLayer.DTOs.User;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Identity;

namespace BusinessLayer.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IMapper _mapper;

    public AuthService(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _mapper = mapper;
    }

    public async Task<IdentityResult> RegisterAsync(RegisterDTO registerDto)
    {
        var user = _mapper.Map<RegisterDTO, User>(registerDto);
        
        return await _userManager.CreateAsync(user, registerDto.Password);
        
    }

    public async Task<SignInResult> LoginAsync(LoginDTO loginDto)
    {
        return await _signInManager.PasswordSignInAsync(loginDto.Email, loginDto.Password, false, false);
    }

    public async Task LogoutAsync()
    {
        await _signInManager.SignOutAsync();
    }
}