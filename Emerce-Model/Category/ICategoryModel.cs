using System;

namespace Emerce_Model.Category
{
    public interface ICategoryModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Idatetime { get; set; }
    }
}
