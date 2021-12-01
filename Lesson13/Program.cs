using System;

namespace Lesson13
{
    class Program
    {
        static void Main()
        {
            try
            {
                var products = new Product[5];
                var product1 = new Product("Cloth", "H&M");
                var product2 = new Product("Orange", "Green");
                var product3 = new Product("Skirt", "Gucci");
                var product4 = new Product("Milk", "Green");
                var product5 = new Product("Dress", "H&M");
                products[0] = product1;
                products[1] = product2;
                products[2] = product3;
                products[3] = product4;
                products[4] = product5;


                Array.Sort(products, (x, y) => string.Compare(x.ProductName, y.ProductName));
                var result = Array.Find(products, x => x.ProductName.Equals("Orange"));
                if (result == null)
                {
                    throw new ShopNotFoundException();
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
