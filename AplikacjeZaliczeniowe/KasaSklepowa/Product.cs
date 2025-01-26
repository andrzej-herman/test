using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaSklepowa
{
    internal class Product
    {
        public Product(string barcode, string name, decimal price)
        {
           Barcode = barcode; 
           Name = name;
           Price = price;
        }

        public string Barcode { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
