using AutoMapper;
namespace Emerce_API.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            /* USER MAPS */
            //create user
            CreateMap<Emerce_DB.Entities.User, Emerce_Model.User.UserCreateModel>();
            CreateMap<Emerce_Model.User.UserCreateModel, Emerce_DB.Entities.User>();
            //login user
            CreateMap<Emerce_DB.Entities.User, Emerce_Model.User.UserLoginModel>();
            CreateMap<Emerce_Model.User.UserLoginModel, Emerce_DB.Entities.User>();

            /* PRODUCT MAPS */
            //product create
            CreateMap<Emerce_Model.Product.ProductCreateModel, Emerce_DB.Entities.Product>();
            CreateMap<Emerce_DB.Entities.Product, Emerce_Model.Product.ProductCreateModel>();

            /* CATEGORY MAPS */
            //category create
            CreateMap<Emerce_Model.Category.CategoryCreateModel, Emerce_DB.Entities.Category>();
            CreateMap<Emerce_DB.Entities.Category, Emerce_Model.Category.CategoryCreateModel>();
        }
    }
}
