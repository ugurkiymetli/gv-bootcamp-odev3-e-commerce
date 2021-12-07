using AutoMapper;
using Emerce_DB;
using Emerce_Model;
using Emerce_Model.Category;
using System;

namespace Emerce_Service.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper mapper;
        public CategoryService( IMapper _mapper )
        {
            mapper = _mapper;
        }

        public General<CategoryCreateModel> Insert( CategoryCreateModel newCategory )
        {
            var result = new General<CategoryCreateModel>() { IsSuccess = false };
            var model = mapper.Map<Emerce_DB.Entities.Category>(newCategory);
            using ( var service = new EmerceContext() )
            {
                model.Idatetimetime = DateTime.Now;
                service.Category.Add(model);
                service.SaveChanges();
                result.Entity = mapper.Map<Emerce_Model.Category.CategoryCreateModel>(model);
                result.IsSuccess = true;
            }
            return result;
        }

    }
}
