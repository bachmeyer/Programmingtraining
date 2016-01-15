using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpfirstday
{
    class Program
    {
        static void Main(string[] args)
        {


            // get first number
            Console.Write("Enter the first number:");
            var firstNum = int.Parse(Console.ReadLine());

            // get second number
            Console.Write("Enter the second number:");
            var secondNum = int.Parse(Console.ReadLine());

            // display result
            var result = firstNum + secondNum;
            Console.WriteLine("The result is " + result.ToString());

            // pause
            Console.ReadLine();
            ////this is the first line of code to run
            //// console.log in Typescript is 
            ////below and must be double quotes, no backticks or single quotes

            //Console.WriteLine("Hello World!");

            ////Math.random() gives a number between 0-1 in typescript
            ////for c sharp you have to create a random object
            //Random rand = new Random();
            //var myNum = rand.NextDouble();
            //var myNum1 = rand.Next(15, 100);
            ////Console.WriteLine(myNum1);
            ////Console.WriteLine(myNum);

            //////writes the current date and time
            ////var curTime = DateTime.Now.ToString("hh:mm:ss");
            ////Console.WriteLine(curTime);
            ////Console.ReadLine();

            ////Console.WriteLine(int.MaxValue);
            ////Console.ReadLine();
            ////                          V the argument,     V what you want it to say
            //Debug.Assert(myNum1 >= 5 && myNum1 < 10, "Oops! My Num is out of range:(");

            ////TS variable: let varName: type
            ////c# variables: type varName

            ////console read line in order to display the above
            ////Console.ReadLine();

        }
    }
}
