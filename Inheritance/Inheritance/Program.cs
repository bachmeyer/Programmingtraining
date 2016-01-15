using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee bill = new FullTimeEmployee
            {
                FirstName = "Bill",
                LastName = "Gates",
                YearsEmployed = 5
            };


            ContractEmployee steve = new ContractEmployee
            {
                FirstName = "Steve",
                LastName = "Jobs",
                MonthsEmployed = 2
            };
            Debug.Assert(bill.ShowFullName() == "Bill Gates", "Wrong Person!");
            Debug.Assert(bill.YearsEmployed == 5, "Wrong Employment History!");
            Debug.Assert(steve.ShowFullName() == "Steve Jobs", "Wrong Person!");
            Debug.Assert(steve.MonthsEmployed == 2, "Wrong Employment History!");


        }
    }
}
