using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpexersizesconditionalstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exersize 1 Write a C# program that prompts the user to input three integer values and find the greatest value of the three values.

            //Console.WriteLine("Enter an integer for user1");
            //int user1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter another integer for user2");
            //int user2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the final integer for user3");
            //int user3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Your numbers are {0}, {1}, {2}", user1, user2, user3);

            //if (user1 > user2 && user1 > user3)
            //{
            //    Console.WriteLine("User1 is the greatest at " + user1 + " value");
            //}
            //else if (user2 > user1 && user2 > user3)
            //{
            //    Console.WriteLine("User 2 is the greatest at " + user2 + " value");
            //}
            //else
            //{
            //    Console.WriteLine("User 3 is the greatest at " + user3 + " value");
            //}
            //Console.ReadLine();

            //Exersize 2: write a program that determines a students grade.

            Console.WriteLine("Enter quiz grade");
            int quiz = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mid-term grade");
            int mid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter final grade");
            int final = int.Parse(Console.ReadLine());

            int ave = (quiz + mid + final) / 3;

            if (ave >= 90 && ave < 101)
            {
                Console.WriteLine("Your got an A!  Congratulations on your " + ave);
            }
            else if (ave >= 80 && ave < 90)
            {
                Console.WriteLine("You got a B!  Congratulations on your " + ave);
            }
            else if (ave >=70 && ave < 80)
            {
                Console.WriteLine("You got a C, Please study more!  Your score was " + ave);
            }
            else if (ave >60 && ave < 70)
            {
                Console.WriteLine("You got a D, I think you could do better.  Your score was " + ave);
            }
            else
            {
                Console.WriteLine("You got an F, Please come in for tutoring.  Your score was " + ave);
            }
            Console.ReadLine();
           


        }
    }
}
