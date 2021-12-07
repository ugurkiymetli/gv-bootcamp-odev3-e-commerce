using AutoMapper;
using Emerce_DB;
using Emerce_Model;
using Emerce_Model.User;
using System;
using System.Collections.Generic;
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
        public General<UserLoginModel> Login( UserLoginModel user )
        {
            var result = new General<UserLoginModel>() { IsSuccess = false };
            var model = mapper.Map<Emerce_DB.Entities.User>(user);
            using ( var service = new EmerceContext() )
            {
                result.Entity = mapper.Map<UserLoginModel>(model);
                result.IsSuccess = service.User
                    .Any(u => !u.IsDeleted && u.IsActive && u.Username == user.Username && u.Password == user.Password);
            }
            return result;
        }

        public General<UserCreateModel> Insert( UserCreateModel newUser )
        {
            var result = new General<UserCreateModel>() { IsSuccess = false };
            var model = mapper.Map<Emerce_DB.Entities.User>(newUser);
            using ( var service = new EmerceContext() )
            {
                model.Idatetime = DateTime.Now;
                service.User.Add(model);
                service.SaveChanges();
                result.Entity = mapper.Map<UserCreateModel>(model);
                result.IsSuccess = true;
            }
            return result;
        }

        public General<UserViewModel> Get()
        {
            var result = new General<UserViewModel>() { IsSuccess = false };
            using ( var service = new EmerceContext() )
            {
                var data = service.User.OrderBy(p => p.Id);
                result.List = mapper.Map<List<UserViewModel>>(data);
                result.IsSuccess = true;
            }
            return result;
        }
    }
}
