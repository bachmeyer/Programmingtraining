using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyMath
{
    class Program
    {
        static void Main(string[] args)
        {
            var inst = new Math();

            Console.WriteLine("{0} / {1} = {2}", 6,2, inst.DoSomething(6,2));
            
            Console.WriteLine("{0} + {1} + {2} = {3}", 3,3,3, inst.DoSomething(3,3,3));
            
            Console.WriteLine("{0} * {1} * {2} * {3} = {4}", 2, 2, 2, 2, inst.DoSomething(2, 2, 2, 2));
            Console.ReadLine();
        }
    }
}
