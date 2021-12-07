using AutoMapper;
using Emerce_DB;
using Emerce_Extension;
using Emerce_Model;
using Emerce_Model.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
                model.Idatetime = DateTime.Now;
                service.Product.Add(model);
                service.SaveChanges();
                result.Entity = mapper.Map<ProductCreateModel>(model);
                result.IsSuccess = true;
            }
            return result;
        }
        public General<ProductViewModel> Get()
        {
            var result = new General<ProductViewModel>() { IsSuccess = false };
            using ( var service = new EmerceContext() )
            {
                var data = service.Product.Include(p => p.Category)
                    .Include(p => p.IuserNavigation)
                    .OrderBy(p => p.Id);

                result.List = mapper.Map<List<ProductViewModel>>(data);

                //Using extension ToTurkishLira here. Takes ProductViewModel item as input and converts price to Turkish Lira type.
                foreach ( var item in result.List )
                {
                    item.ToTurkishLira();
                }
                result.IsSuccess = true;
            }
            return result;
        }

    }
}
