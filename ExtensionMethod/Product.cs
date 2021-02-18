using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
   public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public void PrintProducts()
        {
            Console.WriteLine(this.Id+this.Title+this.Price);
        }
    }
}
