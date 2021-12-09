using Emerce_DB;
using System.Linq;

namespace Emerce_Service.Validator
{
    public class IsValidBase
    {
        public bool IsValidCategory( EmerceContext service, int id )
        {
            var result = false;
            result = service.Category.Any(c => !c.IsDeleted && c.IsActive && c.Id == id);
            return result;
        }
        public bool IsValidUser( EmerceContext service, int id )
        {
            var result = false;
            result = service.User.Any(u => !u.IsDeleted && u.IsActive && u.Id == id);
            return result;
        }
        public bool IsValidProduct( EmerceContext service, int id )
        {
            var result = false;
            result = service.Product.Any(p => !p.IsDeleted && p.IsActive && p.Id == id);
            return result;
        }
    }
}