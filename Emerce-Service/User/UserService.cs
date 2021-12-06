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

        public bool Login( string username, string password )
        {
            bool result = false;

            using ( var service = new EmerceContext() )
            {
                result = service.User.Any(u => !u.IsDeleted && u.IsActive && u.Username == username && u.Password == password);
            }
            return result;
        }

        public General<Emerce_Model.User.UserViewModel> Insert( Emerce_Model.User.UserViewModel newUser )
        {
            var result = new General<Emerce_Model.User.UserViewModel>() { IsSuccess = false };
            var model = mapper.Map<Emerce_DB.Entities.User>(newUser);
            using ( var service = new EmerceContext() )
            {
                model.Idatetime = DateTime.Now;
                service.User.Add(model);
                service.SaveChanges();
                result.Entity = mapper.Map<Emerce_Model.User.UserViewModel>(model);
                result.IsSuccess = true;
            }
            return result;
        }
    }
}
