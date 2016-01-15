using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpvariablesanddatatpesexersize2
{
    class Program
    {
        static void Main(string[] args)
        {
            //exersize 2, it only wanted Console.WriteLine("*****); five times
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("*****");
            }
            Console.ReadLine();

            //exersize 3

            int num1 = 10;
            var num2 = 12.5;
            string word = "C# programming";

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(word);
            Console.ReadLine();

            //exersize 4

            Console.Write("Type your name and hit enter ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);
            Console.WriteLine("Hello " + name + "!");
            Console.Read();

            
        }
    }
}
