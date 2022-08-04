using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponNumber
{
    public static  class UC5_CouponNumber
    {
        public static void CheckUC5_CouponNumber()
        {
            Random random = new Random();

            int[] coupon = new int[7] { 1, 5, 6, 9, 7, 3, 5 };
                int i = 0;
                while ((i < coupon[i]))
                {
                    if (random.Next(1, 10) == coupon[i])
                    {

                        Console.WriteLine(coupon[i]);
                        i++;

                    }

                }

            
        }
    }
}
