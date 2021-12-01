namespace Lesson13
{
    public class Product
    {
        public string ProductName { get; set; }

        public string ShopName { get; set; }

        public Product(string productName, string shopName)
        {
            ProductName = productName;
            ShopName = shopName;
        }
    }
}
