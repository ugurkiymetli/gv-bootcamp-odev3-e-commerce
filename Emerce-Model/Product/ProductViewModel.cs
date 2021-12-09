using System;

namespace Emerce_Model.Product
{
    public class ProductViewModel : IProductModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int Stock { get; set; }
        public DateTime Idatetime { get; set; }
        public DateTime Udatetime { get; set; }
        public string Iuser { get; set; }
    }
}
