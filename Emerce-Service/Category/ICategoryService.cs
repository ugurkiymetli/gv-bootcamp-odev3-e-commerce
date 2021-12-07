using Emerce_Model;
using Emerce_Model.Category;

namespace Emerce_Service.Category
{
    public interface ICategoryService
    {
        public General<CategoryCreateModel> Insert( CategoryCreateModel newCategory );
    }
}
