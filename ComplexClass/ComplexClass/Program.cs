using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var Checking = new Accounts
            {
                Id = 0003214,
                Type = "Checking",
                Amount = 100.00m,
                IsOpen = true
            };
            var Savings = new Accounts
            {
                Id = 0003211,
                Type = "Savings",
                Amount = 0.00m,
                IsOpen = true
            };

            Customer alice = new Customer
            {
                Checking = Checking,
                Savings = Savings
            };

            alice.Checking.Transfer(alice.Savings, 30m);
            Console.WriteLine(alice.Checking.Amount);
            Console.WriteLine(alice.Savings.Amount);
            Console.ReadLine();
                       
        }
    }
}
