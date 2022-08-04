using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public static class UC6_StopWatch
    {
        public static void CheckUC6_StopWatch()
        {
            Console.WriteLine("Give a Starting value");
            double start = Convert.ToDouble(Console.ReadLine());
            
            StopWatch.Start();

            Console.WriteLine("Give an Ending value");
            double stop = Convert.ToDouble(Console.ReadLine());
            StopWatch.Stop();

            TimeSpan T = stopWatch.Elapsed;


            Console.WriteLine("Time Taken to Print the End value :" + T);


        }
    }
}
