using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chsharploopsforloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1: Write C# code to produce the output shown below:
            //*******

            //******

            //*****

            //****

            //***

            //**

            //*


            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 7-i; j++)
            //    {
            //        Console.Write("*");
            //    }             
            //    Console.Write('\n');
            //}
            //Console.ReadLine();


            //Exercize 2 write C# code to print the following pattern
            //1******

            //12*****

            //123****

            //1234****

            //12345**

            //123456*

            //1234567

            for (int i = 0; i < 8; i++)
            {
                for (int j = 1; j <= i; j++)
                Console.Write(j);
                for (int k =7-i; k >=1; k--)
                Console.Write("*");

                Console.Write("\n");
            }
            Console.Read();

        }
    }
}
