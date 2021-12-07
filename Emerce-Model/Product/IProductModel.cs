using System;

namespace Emerce_Model.Product
{
    public interface IProductModel
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public DateTime Idatetime { get; set; }
    }
}
