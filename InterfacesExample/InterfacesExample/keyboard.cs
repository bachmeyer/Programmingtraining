using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    interface IKeyboard
    {
        void PushButton(string buttonToPush);
    }
    class keyboard: IKeyboard
    {
        public void PushButton(string buttonToPush)
        {
            Console.WriteLine(buttonToPush);
        }
    }

    class VirtualKeyboard: IKeyboard
    {
        public void PushButton(string buttonToPush)
        {
            foreach (var letter in buttonToPush) { }
            {
                Console.WriteLine();
            }
        }
    }
}

