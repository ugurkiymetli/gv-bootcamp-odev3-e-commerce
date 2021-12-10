using Emerce_Model;
using Emerce_Service.Product;
using Microsoft.AspNetCore.Mvc;

namespace Emerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController( IProductService _productService )
        {
            productService = _productService;
        }
        //Insert Product
        [HttpPost]
        public General<Emerce_Model.Product.ProductCreateModel> Insert( [FromBody] Emerce_Model.Product.ProductCreateModel newProduct )
        {
            return productService.Insert(newProduct);
        }

        //Get Product
        //[EnableCors("AllowAllHeaders")]
        [HttpGet]
        public General<Emerce_Model.Product.ProductViewModel> Get()
        {
            return productService.Get();
        }
        //Update Product
        [HttpPut("{id}")]
        public General<Emerce_Model.Product.ProductUpdateModel> Update( [FromBody] Emerce_Model.Product.ProductUpdateModel updatedProduct, int id )
        {
            return productService.Update(updatedProduct, id);
        }
        //Delete Product
        [HttpDelete("{id}")]
        public General<Emerce_Model.Product.ProductViewModel> Delete( int id )
        {
            return productService.Delete(id);
        }
    }
}
