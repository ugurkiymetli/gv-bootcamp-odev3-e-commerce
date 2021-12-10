using System;

namespace Emerce_Model.Category
{
    public class CategoryViewModel : ICategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Idatetime { get; set; }
        public DateTime? Udatetime { get; set; }
        public string Iuser { get; set; }
    }
}
