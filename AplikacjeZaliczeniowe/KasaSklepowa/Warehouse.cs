using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaSklepowa
{
    internal static class Warehouse
    {
        public static List<Product> CreateProducts()
        {
            return new List<Product>
            {
                new Product("001", "Masło Extra", 7.99m),
                new Product("002", "Piwo Żubr Puszka 0.5 L", 3.49m),
                new Product("003", "Chleb wiejski 600 g", 4.00m),
            };
        }
    }
}
