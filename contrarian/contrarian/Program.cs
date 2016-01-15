using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contrarian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter what you like, I bet I disagree");
            var userSent = (Console.ReadLine());
            Console.WriteLine(userSent);
            Console.ReadLine();
            //var array = userSent.Split(' ');
            string modified = userSent.Replace("don't", "do");

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == "don't")
            //    {
            //        array[i] = "do";

            //    }
            //    else if (array[i] == "do")
            //    {
            //        array[i] = "don't";

            //    }

            //    else if (array[i] == "agree")
            //    {
            //        array[i] = "disagree";

            //    }

            //    else if (array[i] == "disagree")
            //    {
            //        array[i] = "agree";
            //    }


            //    else if (array[i] == "yes")
            //    {
            //        array[i] = "no";
            //    }

            //    else if (array[i] == "no")
            //    {
            //        array[i] = "yes";
            //    }

            //    else
            //    {
            //        array[i] = array[i];
            //    }






                Console.WriteLine(modified);
                Console.ReadLine();
            //}

        }
    }
};

