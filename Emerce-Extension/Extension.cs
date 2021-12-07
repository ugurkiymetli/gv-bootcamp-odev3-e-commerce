using Emerce_Model.Product;

namespace Emerce_Extension
{
    public static class Extension
    {
        public static void ToTurkishLira( this ProductViewModel product )
        {
            product.Price = $"{product.Price} ₺";
        }
    }
}
