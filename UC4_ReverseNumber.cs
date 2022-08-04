using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    public static  class UC4_ReverseNumber
    {
        public static void CheckUC4_ReverseNumber()
        {
            Console.WriteLine("Reversing a Number");
            int n = 50, calrem, mulvar, addrem, divnum;
            for (int i = 1; i < n; i++)
            {
                calrem = n % i;
                mulvar = calrem * 10;
                addrem = calrem + mulvar;
                divnum = addrem / 10;
                Console.WriteLine(divnum);
            }
           
        }
    }
}
