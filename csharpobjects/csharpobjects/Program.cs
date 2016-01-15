using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpobjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //var milk = new Product()
            //{
            //    Name = "1% Milk",
            //    Price = 3.00m,
            //    Description = "Milk!",
            //    UnitsInStock = 5
            //};
            //                         //V  this enables use to use V values in the string
            //Console.WriteLine("Name: {0}\n{0}'s Price: {1:c}", milk.Name, milk.Price);
            //Console.ReadLine();

            var sally = new Customer() {
                FirstName = "Sally",
                LastName = "William",
                BirthDate = 23
            };
            var mike = new Customer()
            {
                FirstName = "Mike",
                LastName = "Harrison",
                BirthDate = 10
            };

        }
    }
}
