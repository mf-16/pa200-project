using AutoMapper;
using BusinessLayer.DTOs.Auth;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using WebMVC.Models;
using WebMVC.Models.Account;

namespace WebMVC.Controllers;

public class AccountController : Controller
{
    private readonly IAuthService _authService;
    private readonly IMapper _mapper;
    private readonly IMemoryCache _memoryCache;

    public AccountController(IAuthService authService, IMapper mapper, IMemoryCache memoryCache)
    {
        _authService = authService;
        _mapper = mapper;
        _memoryCache = memoryCache;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var registerDto = _mapper.Map<RegisterViewModel, RegisterDTO>(model);
        var result = await _authService.RegisterAsync(registerDto);
        if (result.Succeeded)
        {
            _memoryCache.Remove("Users");

            return RedirectToAction(
                nameof(Login),
                nameof(AccountController).Replace("Controller", "")
            );
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }

        return View(model);
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        var loginDto = _mapper.Map<LoginViewModel, LoginDTO>(model);
        var result = await _authService.LoginAsync(loginDto);
        if (result.Succeeded)
        {
            return RedirectToAction(
                nameof(LoginSuccess),
                nameof(AccountController).Replace("Controller", "")
            );
        }

        ModelState.AddModelError(string.Empty, "Invalid login attempt.");

        return View(model);
    }

    public async Task<IActionResult> Logout()
    {
        await _authService.LogoutAsync();
        return RedirectToAction(
            nameof(HomeController.Index),
            nameof(HomeController).Replace("Controller", "")
        );
    }

    public IActionResult LoginSuccess()
    {
        return View();
    }
}
