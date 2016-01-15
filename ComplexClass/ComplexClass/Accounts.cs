using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class Accounts
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public bool IsOpen { get; set; }

        public void Transfer(Accounts To, decimal n1)
        {
            if (Amount < n1)
            {
                Console.WriteLine("No Denero, No Bueno");
            }
            Amount = Amount - n1;
            To.Amount = To.Amount + n1;
        }
    }
}


