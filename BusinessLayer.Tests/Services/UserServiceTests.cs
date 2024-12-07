using AutoMapper;
using BusinessLayer.DTOs.User;
using BusinessLayer.Exceptions;
using BusinessLayer.Mapper;
using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Identity;
using NSubstitute;
using NSubstitute.ReturnsExtensions;

namespace BusinessLayer.Tests.Services
{
    public class UserServiceTests
    {
        private readonly IUserService _userService;
        private readonly UserManager<User> _mockUserManager;
        private readonly IUnitOfWork _mockUnitOfWork;

        public UserServiceTests()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
            });
            var mockMapper = configuration.CreateMapper();
            _mockUserManager = GetMockUserManager();
            _mockUnitOfWork = Substitute.For<IUnitOfWork>();
            _userService = new UserService(_mockUnitOfWork, mockMapper, _mockUserManager);
        }

        private UserManager<User> GetMockUserManager()
        {
            var store = Substitute.For<IUserStore<User>>();

            return Substitute.For<UserManager<User>>(
                store,
                null,
                null,
                Array.Empty<IUserValidator<User>>(),
                Array.Empty<IPasswordValidator<User>>(),
                null,
                null,
                null,
                null
            );
        }

        [Fact]
        public async Task CreateUserAsync_Success()
        {
            // Arrange
            var newUserDto = new CreateUserDto
            {
                Email = "john.doe@example.com",
                Name = "John Doe",
                Password = "password",
                PhoneNumber = "0123456789",
                UserName = "john.doe",
            };

            _mockUserManager
                .CreateAsync(Arg.Any<User>(), Arg.Any<string>())
                .Returns(Task.FromResult(IdentityResult.Success));

            // Act
            var result = await _userService.CreateUserAsync(newUserDto);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("John Doe", result.Name);
            Assert.Equal("john.doe@example.com", result.Email);
        }

        [Fact]
        public async Task UpdateUserAsync_Success()
        {
            // Arrange
            var updateDto = new UpdateUserDto
            {
                UserName = "john.doe.updated",
                Email = "john.doe.updated@example.com",
                PhoneNumber = "9876543210",
            };

            var existingUser = new User
            {
                Id = 1,
                UserName = "john.doe",
                Email = "john.doe@example.com",
                PhoneNumber = "0123456789",
            };

            _mockUnitOfWork.UserRepository.GetByIdAsync(1).Returns(existingUser);
            _mockUserManager
                .UpdateAsync(Arg.Any<User>())
                .Returns(Task.FromResult(IdentityResult.Success));

            // Act
            var result = await _userService.UpdateUserAsync(1, updateDto);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("john.doe.updated", result.UserName);
            Assert.Equal("john.doe.updated@example.com", result.Email);
        }

        [Fact]
        public async Task UpdateUserAsync_Failure_UserNotFound()
        {
            // Arrange
            var updateDto = new UpdateUserDto
            {
                UserName = "not.found",
                Email = "not.found@example.com",
                PhoneNumber = "9876543210",
            };

            _mockUnitOfWork.UserRepository.GetByIdAsync(999).ReturnsNull();

            // Act & Assert
            await Assert.ThrowsAsync<NotFoundException>(
                () => _userService.UpdateUserAsync(999, updateDto)
            );
        }

        [Fact]
        public async Task DeleteUserAsync_Success()
        {
            // Arrange
            var existingUser = new User
            {
                Id = 1,
                UserName = "john.doe",
                Email = "john.doe@example.com",
                PhoneNumber = "0123456789",
            };

            _mockUnitOfWork.UserRepository.GetByIdAsync(1).Returns(existingUser);
            _mockUserManager
                .DeleteAsync(Arg.Any<User>())
                .Returns(Task.FromResult(IdentityResult.Success));

            // Act
            await _userService.DeleteUserAsync(1);

            // Assert
            await _mockUserManager.Received(1).DeleteAsync(existingUser);
        }

        [Fact]
        public async Task DeleteUserAsync_Failure_UserNotFound()
        {
            // Arrange
            _mockUnitOfWork.UserRepository.GetByIdAsync(999).ReturnsNull();

            // Act & Assert
            await Assert.ThrowsAsync<NotFoundException>(() => _userService.DeleteUserAsync(999));
        }

        [Fact]
        public async Task GetAllUsersAsync_Success()
        {
            // Arrange
            var existingUsers = new List<User>
            {
                new User
                {
                    Id = 1,
                    UserName = "john.doe",
                    Email = "john.doe@example.com",
                    PhoneNumber = "0123456789",
                    Name = "John Doe",
                },
                new User
                {
                    Id = 2,
                    UserName = "jane.doe",
                    Email = "jane.doe@example.com",
                    PhoneNumber = "9876543210",
                    Name = "Jane Doe",
                },
            };

            _mockUnitOfWork.UserRepository.GetAllAsync().Returns(existingUsers);

            // Act
            var result = await _userService.GetAllUsersAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("john.doe", result[0].UserName);
            Assert.Equal("jane.doe", result[1].UserName);
        }

        [Fact]
        public async Task GetUserAsync_Success()
        {
            // Arrange
            var existingUser = new User
            {
                Id = 1,
                UserName = "john.doe",
                Email = "john.doe@example.com",
                PhoneNumber = "0123456789",
                Name = "John Doe",
            };

            _mockUnitOfWork.UserRepository.GetByIdAsync(1).Returns(existingUser);

            // Act
            var result = await _userService.GetUserAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("john.doe", result.UserName);
            Assert.Equal("john.doe@example.com", result.Email);
        }

        [Fact]
        public async Task GetUserAsync_Failure_UserNotFound()
        {
            // Arrange
            _mockUnitOfWork.UserRepository.GetByIdAsync(999).ReturnsNull();

            // Act & Assert
            await Assert.ThrowsAsync<NotFoundException>(() => _userService.GetUserAsync(999));
        }
    }
}
