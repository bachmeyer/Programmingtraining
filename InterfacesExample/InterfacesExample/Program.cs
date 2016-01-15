using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class Program
    {

         static void Main(string[] args)
        {

            Console.WriteLine("the quick brown fox".WordCount());
            Console.WriteLine(Counter.CountWords("Hello World"));
            Console.WriteLine(Counter.CountWords("onlyoneword"))


            PushTheSpaceButton(new keyboard());
            PushTheSpaceButton(new VirtualKeyboard());

            Console.ReadLine();

        }
        static void PushTheSpaceButton(IKeyboard keyboard)
        {
            keyboard.PushButton("Space");
        }

        public static int CountWords(string sentence)
        {
            return Counter.CountWords(sentence);
        }
    }

}
