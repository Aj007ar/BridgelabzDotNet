using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class CouponNumber
    {
        public void Coupons()
        {
            int dist=0;
            int count = 0;
            int newCoupon;
            Console.WriteLine("Enter number for coupon");
            int coupon = Convert.ToInt32(Console.ReadLine());
            bool[] couponCollect = new bool[coupon];

            while (dist < coupon)
            {
                Random random = new Random();
                newCoupon = (int)(random.NextDouble() * coupon);
                count++;
            }
            if (!couponCollect[newCoupon])
            {
                dist++;
                couponCollect[newCoupon] = true;
            }
         }
    }
}
