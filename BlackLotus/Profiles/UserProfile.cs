using AutoMapper;
using BlackLotus.DTO;
using BlackLotus.Model;

namespace BlackLotus.Profiles
{
    
        public class UserProfile : Profile
        {
            public UserProfile()
            {
                CreateMap<User, UserReadDTO>();
                CreateMap<UserCreateDTO, User>();
            }

        }
    
}
