using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    public static class UC1_FibonacciSeries
    {
        public static void CheckUC1_FibonacciSeries()
        {
            int num1 = 0,
           num2 = 1,
           num3,
            i,
           myNum = 10;

            Console.WriteLine("The fibonacci series are : ");

            for (i = 0; i < myNum; ++i)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
