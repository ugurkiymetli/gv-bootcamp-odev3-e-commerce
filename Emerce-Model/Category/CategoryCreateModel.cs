using System;
using System.ComponentModel.DataAnnotations;

namespace Emerce_Model.Category
{
    public class CategoryCreateModel : ICategoryModel
    {
        [Required(ErrorMessage = "{0} is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public DateTime Idatetime { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public int Iuser { get; set; }

    }
}
