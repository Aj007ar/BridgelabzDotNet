using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompareProblem
{
    internal class UC1LentghCal
    {
        public void LineLength(double x1,double y1,double x2,double y2)
        {
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2));
            double b = Math.Sqrt(Math.Pow(y2 - y1, 2));
            double c = a + b;
            Console.WriteLine(c);
        }
    }
}
