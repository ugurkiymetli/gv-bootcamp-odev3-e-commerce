using AutoMapper;
using Emerce_DB;
using Emerce_Model;
using Emerce_Model.Category;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
                model.Idatetime = DateTime.Now;
                service.Category.Add(model);
                service.SaveChanges();
                result.Entity = mapper.Map<Emerce_Model.Category.CategoryCreateModel>(model);
                result.IsSuccess = true;
            }
            return result;
        }
        public General<CategoryViewModel> Get()
        {
            var result = new General<CategoryViewModel>() { IsSuccess = false };
            using ( var service = new EmerceContext() )
            {
                var data = service.Category
                    .Include(p => p.IuserNavigation)
                    .OrderBy(p => p.Id);
                result.List = mapper.Map<List<CategoryViewModel>>(data);
                result.IsSuccess = true;
            }
            return result;
        }
    }
}
