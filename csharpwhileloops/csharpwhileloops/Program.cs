using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpwhileloops
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Exercise 1: Write C# program to prompt the user to choose the correct answer from a list of answer choices of a question.
            //The user can choose to continue answering the question or stop answering it.See the example below:
            //What is the command keyword to exit a loop in C#?
            //a. int
            //b. continue
            //c. break
            //d.exit
            //Enter your choice: b
            //Incorrect!
            //Again ? press y to continue:


            while( useranswer != "c" || useranswer != y)
            Console.WriteLine("What is the command keyword to exit a loop in c#?");
            Console.WriteLine("a. int");
            Console.WriteLine("b. continue");
            Console.WriteLine("c. break");
            Console.WriteLine("d. exit");
            Console.WriteLine("Enter your choice: ");
            string useranswer = Console.ReadLine();

            while (useranswer == "c")
            {
                Console.WriteLine("Correct");
            }
            while(user)



        }
    }
}
