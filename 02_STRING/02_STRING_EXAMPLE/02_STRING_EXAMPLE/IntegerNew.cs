using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _02_STRING_EXAMPLE
{
    class IntegerNew
    {
        public IntegerNew()
        {
            int ctr = 0;
            Console.WriteLine("Loop Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000000; i++)
            {
                ctr = ctr + 1;
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
        }
    }
}
