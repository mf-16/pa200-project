using AutoMapper;
using BusinessLayer.DTOs.User;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserDto, User>();
        CreateMap<User, ResponseUserDto>();
        CreateMap<UpdateUserDto, User>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
    }
}
