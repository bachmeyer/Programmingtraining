using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpexersizesoperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //arithmatic and padding
            //int x = 10;
            //int y = 5;
            //Console.WriteLine("x value y value expression result");
            //Console.WriteLine("{0,-8} {1,-8}x=y+3      x={2,-8}", x, y, y + 3);
            //Console.WriteLine("{0,-8} {1,-8}x=y-2      x={2,-8}", x, y, y - 2);
            //Console.WriteLine("{0,-8} {1,-8}x=y*2      x={2,-8}", x, y, y * 5);
            //Console.WriteLine("{0,-8} {1,-8}x=x/y      x={2,-8}", x, y, x / y);
            //Console.WriteLine("{0,-8} {1,-8}x=x%y      x={2,-8}", x, y, x % y);
            //Console.ReadLine();


            //arithmatic and padding again
            //int x = 10;
            //int y = 5;
            //Console.WriteLine("x value y value expression result");
            //Console.WriteLine("{0,-8} {1, -8}x+=y       x={2, -8}", x, y, x+ y);
            //Console.WriteLine("{0,-8} {1, -8}x-=y-2     x={2, -8}", x, y, x-y+2);
            //Console.WriteLine("{0, -8} {1, -8}x*=y*5    x={2, -8}", x, y, x*y*5);
            //Console.WriteLine("{0, -8} {1, -8}x/x/y     x={2, -8}", x, y, x / (x / y));
            //Console.WriteLine("{0, -8} {1, -8}x%=y      x={2, -8}", x, y, x % y);

            //arithmatic exersize
            Console.WriteLine("Enter an integer value");
            int anum = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of a is {0}", anum);
            Console.WriteLine("The value of ++a is {0}", ++anum);
            Console.WriteLine("The value of a is {0}", anum);
            Console.WriteLine("The value of a++ is {0}", anum++);
            Console.WriteLine("The value of a is {0}", anum);
            Console.WriteLine("The value of --a is {0}", --anum);
            Console.WriteLine("The value of a is {0}", anum);
            Console.WriteLine("The value of a-- is {0}", anum--);
            Console.WriteLine("The value of a is {0}", anum);
            Console.ReadLine();
            Console.Read();
        }
    }
}
