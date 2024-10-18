using BusinessLayer.DTOs.User;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<ActionResult<ResponseUserDto>> CreateUser([FromBody] CreateUserDto user)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(await _userService.CreateUserAsync(user));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ResponseUserDto>> UpdateUser(int id, [FromBody] UpdateUserDto user)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(await _userService.UpdateUserAsync(id, user));
        
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ResponseUserDto>> DeleteUser(int id)
    {
        await _userService.DeleteUserAsync(id);
        return Ok(new { message = "User successfully deleted" });
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<ResponseUserDto>> GetUser(int id)
    {
        return Ok(await _userService.GetUserAsync(id));
    }
    
    
    [HttpGet]
    public async Task<ActionResult<ResponseUserDto>> GetAllUsers()
    {
        return Ok(await _userService.GetAllUsersAsync());
    }
    
}