using AutoMapper;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using WebMVC.Models.User;

namespace WebMVC.Controllers;

[Route("users")]
[Authorize(Roles = "Admin")]
public class UserController : Controller
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;
    private readonly IMemoryCache _memoryCache;
    private readonly ILogger<UserController> _logger;

    public UserController(
        IUserService userService,
        IMapper mapper,
        IMemoryCache memoryCache,
        ILogger<UserController> logger
    )
    {
        _userService = userService;
        _mapper = mapper;
        _memoryCache = memoryCache;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        var cacheKey = "Users";
        if (!_memoryCache.TryGetValue(cacheKey, out List<UserViewModel>? users))
        {
            _logger.LogInformation($"Cache miss for {cacheKey} at {DateTime.Now}");
            var usersDto = await _userService.GetAllUsersAsync();
            users = _mapper.Map<List<UserViewModel>>(usersDto);
            _memoryCache.Set(cacheKey, users, TimeSpan.FromMinutes(10));
        }
        else
        {
            _logger.LogInformation($"Cache hit for {cacheKey} at {DateTime.Now}");
        }

        return View(users);
    }

    [HttpPost]
    public async Task<IActionResult> ResetPassword(int userId, string newPassword)
    {
        var result = await _userService.ResetPasswordAsync(userId, newPassword);

        _memoryCache.Remove("Users");

        if (result.Succeeded)
        {
            TempData["Success"] = "Password has been changed successfully.";
        }
        else
        {
            TempData["Error"] = "Failed to change password.";
        }

        return RedirectToAction("Index");
    }
}
