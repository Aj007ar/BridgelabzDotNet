using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectMethod
{
  
    internal class CalculatorMethod
    {
        int num1 = 10;
        int num2 = 10;

        public void Addition()
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }
        public void substraction()
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }
        public void multiplication()
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }
        public void division()
        {
            int result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}
