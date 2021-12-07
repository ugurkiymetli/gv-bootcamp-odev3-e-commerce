using AutoMapper;
using Emerce_DB;
using Emerce_Model;
using System;
using System.Linq;
namespace Emerce_Service.User
{
    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        public UserService( IMapper _mapper )
        {
            mapper = _mapper;
        }

        //public bool Login( string username, string password )
        //{
        //    bool result = false;

        //    using ( var service = new EmerceContext() )
        //    {
        //        result = service.User.Any(u => !u.IsDeleted && u.IsActive && u.Username == username && u.Password == password);
        //    }
        //    return result;
        //}
        public General<Emerce_Model.User.UserLoginModel> Login( Emerce_Model.User.UserLoginModel user )
        {
            var result = new General<Emerce_Model.User.UserLoginModel>() { IsSuccess = false };
            var model = mapper.Map<Emerce_DB.Entities.User>(user);
            using ( var service = new EmerceContext() )
            {
                result.Entity = mapper.Map<Emerce_Model.User.UserLoginModel>(model);
                result.IsSuccess = service.User
                    .Any(u => !u.IsDeleted && u.IsActive && u.Username == user.Username && u.Password == user.Password);
            }
            return result;
        }

        public General<Emerce_Model.User.UserCreateModel> Insert( Emerce_Model.User.UserCreateModel newUser )
        {
            var result = new General<Emerce_Model.User.UserCreateModel>() { IsSuccess = false };
            var model = mapper.Map<Emerce_DB.Entities.User>(newUser);
            using ( var service = new EmerceContext() )
            {
                model.Idatetimetime = DateTime.Now;
                service.User.Add(model);
                service.SaveChanges();
                result.Entity = mapper.Map<Emerce_Model.User.UserCreateModel>(model);
                result.IsSuccess = true;
            }
            return result;
        }
    }
}
