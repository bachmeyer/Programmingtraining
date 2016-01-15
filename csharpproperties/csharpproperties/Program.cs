using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //var milk = new Product()
            //{
            //    Name = "Milk",
            //    Price = 1.5m
            //};
            //milk.ApplyDiscount(percent: .03m, flat: .20m);

            //Console.WriteLine("{0} Price: {1:c}", milk.Name, milk.Price);
            //Console.ReadLine();

            var inst = new Math();

            Console.WriteLine("{0} + {1} - {2}" , 5, 7, inst.AddNumbers(5, 7));
            Console.ReadLine();

        }
    }
}
