using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Counter.CountWords("The quick brown fox"));
            Console.ReadLine();

        }
    }
}
