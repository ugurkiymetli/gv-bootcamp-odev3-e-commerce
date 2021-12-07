using Emerce_Model;

namespace Emerce_Service.Product
{
    public interface IProductService
    {
        public General<Emerce_Model.Product.ProductCreateModel> Insert( Emerce_Model.Product.ProductCreateModel newProduct );
        public General<Emerce_Model.Product.ProductViewModel> Get();
        public General<Emerce_Model.Product.ProductViewModel> Delete( int id );
    }
}
