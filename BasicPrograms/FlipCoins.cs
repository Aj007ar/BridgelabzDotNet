using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class FlipCoins
    {
        public void HaidTail()
        {
            int heads = 0;
            int tails = 0;
            Console.WriteLine("enter how many times coin flipped: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Random random = new Random();
                double ran = random.NextDouble();
                //Console.WriteLine("Random Input "+ran);

                if (ran <= 0.5)
                { 
                        //Console.WriteLine("Heads");
                        heads = heads + 1;
                }
                else
                {
                        //Console.WriteLine("Tails");
                        tails = tails + 1;
                }
                
            }
            Console.WriteLine("Total number Heads {0} \nTotal number of Tails {1}", heads, tails);

        }
    }
    
}
