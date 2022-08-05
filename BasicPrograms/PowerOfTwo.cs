using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class PowerOfTwo
    {
        public void PowerTwo()
        {
            Console.WriteLine("Enter number for power of two");
            int power = Convert.ToInt32(Console.ReadLine());

            if ((power > 0) && (power < 31))
            {
                Double pow = Math.Pow(2, power);
                Console.WriteLine("2 power of {0} is {1}",power,pow);
            }
        }
    }
}
