using AutoMapper;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models.User;

namespace WebMVC.Controllers;
[Route("users")]
[Authorize(Roles = "Admin")]
public class UserController : Controller
{
    
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UserController(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        var users = await _userService.GetAllUsersAsync();
        var mappedUsers = _mapper.Map<List<UserViewModel>>(users);
        
        return View(mappedUsers);
        
    }

    [HttpPost]
    public async Task<IActionResult> ResetPassword(int userId, string newPassword)
    {
        var result = await _userService.ResetPasswordAsync(userId, newPassword);

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