using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconstructors
{
    class Products
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public string Description { get; set; }

        public Products(string name, decimal price, int units)
        {
            Name = name;
            Price = price;
            UnitsInStock = units;
        }
        public Products(string name, decimal price, int units, string desc)
        {
            Name = name;
            Price = price;
            UnitsInStock = units;
            Description = desc;
        }

    }
}
