using AutoMapper;
using BusinessLayer.DTOs.User;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;

    public UserService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<User> userManager)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<ResponseUserDto> CreateUserAsync(CreateUserDto dto)
    {
        var user = _mapper.Map<User>(dto);
        var result = await _userManager.CreateAsync(user, dto.Password);
        if (!result.Succeeded)
        {
            throw new UserOperationException($"Unable to create user");
        }

        return _mapper.Map<ResponseUserDto>(user);
    }

    public async Task<ResponseUserDto> UpdateUserAsync(int id, UpdateUserDto dto)
    {
        var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
        {
            throw new NotFoundException(nameof(User), id);
        }
        _mapper.Map(dto, user);
        var result = await _userManager.UpdateAsync(user);
        if (!result.Succeeded)
        {
            throw new UserOperationException($"Unable to update user");
        }
        return _mapper.Map<ResponseUserDto>(user);
    }

    public async Task DeleteUserAsync(int id)
    {
        var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
        {
            throw new NotFoundException(nameof(User), id);
        }
        var result = await _userManager.DeleteAsync(user);
        if (!result.Succeeded)
        {
            throw new UserOperationException($"Unable to delete user");
        }
    }

    public async Task<List<ResponseUserDto>> GetAllUsersAsync()
    {
        var users = await _userManager.Users.ToListAsync();
        return _mapper.Map<List<ResponseUserDto>>(users);
    }

    public async Task<ResponseUserDto> GetUserAsync(int id)
    {
        var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
        {
            throw new NotFoundException(nameof(User), id);
        }
        return _mapper.Map<ResponseUserDto>(user);
    }
}
