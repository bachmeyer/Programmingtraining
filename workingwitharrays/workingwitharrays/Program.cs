using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingwitharrays
{
    class Program
    {
        private static object random;

        static void Main(string[] args)
        {
            var fortunes = new string[] {
                "I see a large jackpot in your future",
                "I see a new love in your future",
                "Your future is blurred by many choices"
            };

            var rand = new Random();

            Console.Write(fortunes[rand.Next(fortunes.Length)]);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
