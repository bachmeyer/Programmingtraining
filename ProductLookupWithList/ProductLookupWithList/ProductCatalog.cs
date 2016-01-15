using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithList
{
    class ProductCatalog

    {

        public Dictionary<string, Product> Products { get; set; }

        public ProductCatalog()
        {

            Products = new Dictionary<string, Product>();
            Products["UY8890NB"] = new Product()
            {
                Id = "UY8890NB",
                Name = "FirstProduct",
                Price = 1.5m
            };
            Products["AB8890NA"] = new Product()
            {
                Id = "AB8890NA",
                Name = "SecondProduct",
                Price = 1.2m
            };

            Products["CC8890CC"] = new Product()
            {
                Id = "CC8890CC",
                Name = "ThirdProduct",
                Price = 2.0m
            };
        }
        public Product Lookup(string id)
        {

            if (Products.ContainsKey(id))
            {
                return Products[id];
            }
        }
        return null;
        }

}


