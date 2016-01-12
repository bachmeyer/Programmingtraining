using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your sentance:");
            var userSent = (Console.ReadLine());
            Console.WriteLine(userSent);
            Console.ReadLine();
            var array = userSent.Split(' ');
            for (int i = array.Length - 1; i >= 0; i--)
            {
                
                Console.WriteLine(array[i]);
                Console.ReadLine();
            }





        }
    }
}
