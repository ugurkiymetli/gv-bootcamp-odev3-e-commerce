using System;
using System.ComponentModel.DataAnnotations;

namespace Emerce_Model.Product
{
    public class ProductCreateModel : IProductModel
    {
        //public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters long.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters long.")]
        public string DisplayName { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(250, ErrorMessage = "{0} cannot be more than {1} characters long.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public DateTime Idatetime { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public int Iuser { get; set; }
    }
}
