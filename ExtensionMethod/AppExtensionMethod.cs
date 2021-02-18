using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    public static class AppExtensionMethod
    {
        public static int ProductPriceUpdate(this Product p,int price)
        {
            p.Price = p.Price * price;
            return p.Price;
        }
    }
}
