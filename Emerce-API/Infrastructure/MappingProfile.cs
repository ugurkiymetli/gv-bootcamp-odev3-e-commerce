using AutoMapper;
namespace Emerce_API.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Emerce_DB.Entities.User, Emerce_Model.User.UserViewModel>();
            CreateMap<Emerce_Model.User.UserViewModel, Emerce_DB.Entities.User>();
            CreateMap<Emerce_DB.Entities.User, Emerce_Model.User.UserLoginModel>();
            CreateMap<Emerce_Model.User.UserLoginModel, Emerce_DB.Entities.User>();
        }
    }
}
