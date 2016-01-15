using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithTests
{
    public class Calculator
    {
        public double AddNum1(params double[] nums) {
            //double sum = 0;
            //foreach (double val in nums)
            //{
            //    sum += val;
            //}
            //return sum;
            return nums.Sum();
        }
        public double SubNum2(double n1, double n2) {
            return n1 - n2;
        }

        public double DivNum(double n1, double n2) {
            return n1 / n2;
        }
        public double MultNum(double n1, double n2) {
            return n1 * n2;
        }

        public double Exp(double b, double exp)
        {
            return Math.Pow(b, exp);
        }
                       
        
    }
}
