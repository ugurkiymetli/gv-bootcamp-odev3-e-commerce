using Emerce_Model;

namespace Emerce_Service.Product
{
    public interface IProductService
    {
        public General<Emerce_Model.Product.ProductCreateModel> Insert( Emerce_Model.Product.ProductCreateModel newProduct );
    }
}
