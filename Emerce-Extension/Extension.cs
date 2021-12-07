using Emerce_Model.Product;

namespace Emerce_Extension
{
    public static class Extension
    {
        public static string ToTurkishLira( this ProductViewModel product )
        {
            return $"{product.Price} ₺ (TL)";
        }
    }
}
