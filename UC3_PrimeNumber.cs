using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber
{
     public  static class UC3_PrimeNumber
    {
        public static void CheckUC3_PrimeNumber()
        {
            int p = Convert.ToInt16(Console.ReadLine());
            int n = 0;
            for (int i = 1; i <= p; i++)
            {
                if (p % i == 0)
                {
                    n++;
                }
            }
            if (n == 2)
            {
                Console.WriteLine(" It is a Prime Number");
            }
            else
            {
                Console.WriteLine("It is Not a Prime Number");
            }
        }
    }
}
