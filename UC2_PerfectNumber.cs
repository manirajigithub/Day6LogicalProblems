using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    public static class UC2_PerectNumber
    {
        public static void CheckUC2_PerfectNumber()
        {
            int a = 2;
            while (a < 10)
            {
                double b = (Math.Pow(2, a - 1));
                double c = (Math.Pow(2, a) - 1);
                double d = b * c;
                Console.WriteLine(d);
                a++;
                if (d % a != 0)
                {
                    Console.WriteLine(d + "  : It is Perfect Number");

                }
            }
        }
    }
}




