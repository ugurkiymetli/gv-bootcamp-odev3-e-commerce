using Emerce_Model;
using Emerce_Service.User;
using Microsoft.AspNetCore.Mvc;

namespace Emerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController( IUserService _userService )
        {
            userService = _userService;
        }

        //Insert User returns General Object with IsSuccess, ErrorList, Posted Data...
        [HttpPost]
        [Route("register")]
        public General<Emerce_Model.User.UserCreateModel> Insert( [FromBody] Emerce_Model.User.UserCreateModel newUser )
        {
            return userService.Insert(newUser);
        }

        //Login User = takes General object and returns general object with isSuccess : true/false
        [HttpPost]
        [Route("login")]
        public General<Emerce_Model.User.UserLoginModel> Login( [FromBody] Emerce_Model.User.UserLoginModel user )
        {
            return userService.Login(user);
        }
        //Get All User = returns users in General object List
        [HttpGet]
        public General<Emerce_Model.User.UserViewModel> Get()
        {
            return userService.Get();
        }

        //Delete User = throws ex if user is not found

        [HttpDelete("{id}")]
        /*public void Delete( int id )
        {
            userService.Delete(id);
        }*/
        public General<Emerce_Model.User.UserViewModel> Delete( int id )
        {
            return userService.Delete(id);
        }

    }
}
