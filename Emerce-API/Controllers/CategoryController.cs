using Emerce_Model;
using Emerce_Service.Category;
using Microsoft.AspNetCore.Mvc;

namespace Emerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController( ICategoryService _categoryService )
        {
            categoryService = _categoryService;
        }
        //Insert Category
        [HttpPost]
        public General<Emerce_Model.Category.CategoryCreateModel> Insert( [FromBody] Emerce_Model.Category.CategoryCreateModel newCategory )
        {
            return categoryService.Insert(newCategory);
        }
        //Get Category
        [HttpGet]
        public General<Emerce_Model.Category.CategoryViewModel> Get()
        {
            return categoryService.Get();
        }

        //Delete User = throws ex if user is not found

        [HttpDelete("{id}")]
        public General<Emerce_Model.Category.CategoryViewModel> Delete( int id )
        {
            return categoryService.Delete(id);
        }
    }
}
