using AutoMapper;
using Emerce_DB;
using Emerce_Model;
using Emerce_Model.Product;
using System;
namespace Emerce_Service.Product
{
    public class ProductService : IProductService
    {
        private readonly IMapper mapper;

        public ProductService( IMapper _mapper )
        {
            mapper = _mapper;
        }

        public General<ProductCreateModel> Insert( ProductCreateModel newProduct )
        {
            var result = new General<ProductCreateModel>() { IsSuccess = false };
            var model = mapper.Map<Emerce_DB.Entities.Product>(newProduct);
            using ( var service = new EmerceContext() )
            {
                model.Idatetimetime = DateTime.Now;
                service.Product.Add(model);
                service.SaveChanges();
                result.Entity = mapper.Map<Emerce_Model.Product.ProductCreateModel>(model);
                result.IsSuccess = true;
            }
            return result;
        }
    }
}
