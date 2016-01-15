using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpobjects
{
    class Product
    {
        public string Name { get; set; }
        //These are auto implemented property, they are not allowed to access the back end fields, prop tab tab opens autofill
        public decimal Price { get; set; }

        //public string Description { get; set; }

        public int UnitsInStock { get; set; }
        // V this is a full property that are allowed to access the back end fields, fullprop tab tab opens autofill
        public decimal TotalPrice
        {
            get { return Price * 1.08m; }
            set { Price = value / 1.08m; }
        }
        private decimal _price;
        public string Price
        {
            get
            {
                return _price.ToString("c");
            }
            set
            {
                _price = decimal.Parse(value);
            }
        }
    }



}
}
