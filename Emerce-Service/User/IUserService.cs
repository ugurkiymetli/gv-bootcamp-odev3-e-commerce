using Emerce_Model;

namespace Emerce_Service.User
{
    public interface IUserService
    {
        public General<Emerce_Model.User.UserViewModel> Insert( Emerce_Model.User.UserViewModel newUser );
        public bool Login( string username, string password );
    }
}
