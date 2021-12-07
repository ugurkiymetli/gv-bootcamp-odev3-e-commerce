using System;

namespace Emerce_Model.Product
{
    public class ProductCreateModel
    {
        //public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Idatetimetime { get; set; }
        public int Iuser { get; set; }
    }
}
