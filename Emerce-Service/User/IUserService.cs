using Emerce_Model;

namespace Emerce_Service.User
{
    public interface IUserService
    {
        public General<Emerce_Model.User.UserViewModel> Insert( Emerce_Model.User.UserViewModel newUser );
        public General<Emerce_Model.User.UserLoginModel> Login( Emerce_Model.User.UserLoginModel user );
    }
}
