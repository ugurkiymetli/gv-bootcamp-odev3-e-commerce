using System;

namespace Emerce_Model.User
{
    public class UserViewModel : IUserModel

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime Idatetime { get; set; }
    }
}
