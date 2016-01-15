using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproperties
{
    class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public void ApplyDiscount(decimal percent = 0m, decimal flat = 0m) {
            Price = Price * (1 - percent) - flat;

            }
        
        //function for overloading allowing strings to be returned instead of decimals
        public void ApplyDiscount(string percent = "0", string flat = "0")
        {
            ApplyDiscount(decimal.Parse(percent), decimal.Parse(flat));
        }




    }
}
