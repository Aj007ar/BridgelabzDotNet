using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectMethod
{
  
    internal class CalculatorMethod
    {
        int num1 = 40;
        int num2 = 20;

        public void Addition()
        {
            int result = num1 + num2;
            Console.WriteLine("Addition is: "+result);
        }
        public void substraction()
        {
            int result = num1 - num2;
            Console.WriteLine("Substraction is: "+result);
        }
        public void multiplication()
        {
            int result = num1 * num2;
            Console.WriteLine("Multiplication is: "+result);
        }
        public void division()
        {
            int result = num1 / num2;
            Console.WriteLine("Division is: "+result);
        }
    }
}
