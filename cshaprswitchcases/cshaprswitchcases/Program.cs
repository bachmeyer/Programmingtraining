using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshaprswitchcases
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercize 1: Write a csharp program to detect key presses from 0-9, if anything else is pressed, the program will show "Not Allowed"

            //Console.WriteLine("Press a number key");
            //char key = (char)Console.Read();
            //switch (key)
            //{
            //    case '0':
            //        Console.WriteLine("You pressed 0");
            //        break;
            //    case '1':
            //        Console.WriteLine("You pressed 1");
            //        break;
            //    case '2':
            //        Console.WriteLine("You pressed 2");
            //        break;
            //    case '3':
            //        Console.WriteLine("You pressed 3");
            //        break;
            //    case '4':
            //        Console.WriteLine("You pressed 4");
            //        break;
            //    case '5':
            //        Console.WriteLine("You pressed 5");
            //        break;
            //    case '6':
            //        Console.WriteLine("You pressed 6");
            //        break;
            //    case '7':
            //        Console.WriteLine("You pressed 7");
            //        break;
            //    case '8':
            //        Console.WriteLine("You pressed 8");
            //        break;
            //    case '9':
            //        Console.WriteLine("You pressed 9");
            //        break;

            //    default:
            //        Console.WriteLine("Not allowed");
            //        break;


            //}

            //Exercize 2 write a program that allow the user to choose the correct answer to a question

            Console.WriteLine("What is the correct way to read a VASI when landing an airplane");
            Console.WriteLine("A-Red over Red");
            Console.WriteLine("B-White over white");
            Console.WriteLine("C-Red over white");
            Console.WriteLine("D-White over Red");
            string user = Console.ReadLine();
            switch (user)
            {
                case "A":
                    Console.WriteLine("Incorrect, the correct answer was C, Red over white, and you're all right is the best way to remember it");
                    break;
                case "B":
                    Console.WriteLine("Incorrect, the correct answer was C, Red over white, and you're all right is the best way to remember it");      break;
                case "C":
                    Console.WriteLine("You are correct, the answer was C, Red over white, and you're all right is the best way to remember it!  Congratulations");
                    break;
                case "D":
                    Console.WriteLine("Incorrect, the correct answer was C, Red over white, and you're all right is the best way to remember it");
                    break;
                case "a":
                    Console.WriteLine("Incorrect, the correct answer was C, Red over white, and you're all right is the best way to remember it");
                    break;
                case "b":
                    Console.WriteLine("Incorrect, the correct answer was C, Red over white, and you're all right is the best way to remember it");
                    break;
                case "c":
                    Console.WriteLine("You are correct, the answer was C, Red over white, and you're all right is the best way to remember it!  Congratulations");
                    break;
                case "d":
                    Console.WriteLine("Incorrect, the correct answer was C, Red over white, and you're all right is the best way to remember it");
                    break;
                default:
                    Console.WriteLine("You did not enter a valid answer choice, please try again");
                    break;
            }
            Console.ReadLine();



        }
    }
}
