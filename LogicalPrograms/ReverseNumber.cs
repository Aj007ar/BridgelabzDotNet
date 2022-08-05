using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            int rev = 0;
            Console.WriteLine("\nEnter any numbers for Reversing");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num+" original number");

            while (num != 0)
            {
                int num2 = num % 10;
                rev = rev * 10 + num2;
                num /= 10;
            }
            Console.WriteLine(rev+" Reversed number ");
        }
    }
}
