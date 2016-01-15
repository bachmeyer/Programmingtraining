using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticmethods
{
    class Counter
    {
       

        public static int CountWords(string sentence) {

            return sentence.Split(' ').Length;
        }



    }
}
