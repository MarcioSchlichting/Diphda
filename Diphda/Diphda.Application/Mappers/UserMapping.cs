namespace Diphda.Application
{
    using AutoMapper;
    using Diphda.Domain.Account;

    public sealed class UserMapping : Profile 
    {
        public UserMapping()
        {
            UserMap();
        }

        private void UserMap()
        {
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username));

            CreateMap<UserDTO, User>()
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username));
        }
    }
}