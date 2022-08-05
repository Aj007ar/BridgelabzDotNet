using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class primeFactor
    {
        public void Factor()
        {
            Console.WriteLine("Enter a number for prime factor");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i < n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i+" ");
                    n /= i;
                }
            }
            if (n > 2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
