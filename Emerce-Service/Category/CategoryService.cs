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
            var result = new General<CategoryCreateModel>();
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
            var result = new General<CategoryViewModel>();
            using ( var service = new EmerceContext() )
            {
                var data = service.Category
                    .Where(c => c.IsActive && !c.IsDeleted)
                    .Include(c => c.IuserNavigation)
                    .OrderBy(c => c.Id);
                result.List = mapper.Map<List<CategoryViewModel>>(data);
                result.IsSuccess = true;
                result.TotalCount = data.Count();
            }
            return result;
        }
        public General<CategoryViewModel> Delete( int id )
        {
            var result = new General<CategoryViewModel>();
            using ( var service = new EmerceContext() )
            {
                var data = service.Category.SingleOrDefault(c => c.Id == id);
                if ( data is null )
                {
                    result.ExceptionMessage = $"Category with id: {id} is not found";
                    return result;
                }
                bool categoryHasProducts = service.Product.Any(c => c.CategoryId == id);
                if ( categoryHasProducts )
                {
                    result.ExceptionMessage = $"Category with id: {id} has products and cannot be deleted!";
                    return result;
                }
                service.Category.Remove(data);
                service.SaveChanges();
                result.Entity = mapper.Map<CategoryViewModel>(data);
                result.IsSuccess = true;
            }
            return result;
        }
    }
}
