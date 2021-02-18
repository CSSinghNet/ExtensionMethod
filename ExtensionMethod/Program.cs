using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pr = new Product() { 
            Id=1,
            Title="Pen",
            Price=20
            };
            pr.PrintProducts();
            Product pr2 = new Product()
            {
                Id = 2,
                Title = "Paper",
                Price = 30
            };
            pr2.PrintProducts();

            var updatePrice=pr.ProductPriceUpdate(10);
            Console.WriteLine(updatePrice);
            

        }
    }
}
