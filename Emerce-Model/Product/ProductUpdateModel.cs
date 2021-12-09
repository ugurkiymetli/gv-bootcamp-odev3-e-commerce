using System;
using System.ComponentModel.DataAnnotations;
namespace Emerce_Model.Product
{
    public class ProductUpdateModel : IProductModel

    {
        public int CategoryId { get; set; }

        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters long.")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters long.")]
        public string DisplayName { get; set; }

        [StringLength(250, ErrorMessage = "{0} cannot be more than {1} characters long.")]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime? Udatetime { get; set; }
        public int? Uuser { get; set; }
    }
}
