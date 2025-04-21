using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _02_STRING_EXAMPLE
{
    //Example: String New Object
    class StringNew
    {
        public StringNew()
        {
            string str = "";
            Console.WriteLine("Loop Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000000; i++)
            {
                str = Guid.NewGuid().ToString();    //create a new instance at everytime
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);

        }
    }

    //Example: String with Same value in C#
    class StringSame
    {
        public StringSame()
        {
            string str = "";
            Console.WriteLine("Loop Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000000; i++)
            {
                str = "DotNet Tutorials";
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);

        }
    }

    //Example: String Concat 
    //As We already Known everytimg concat string will create new object and old object will be garbae collection.
    class StringConcat
    {
        public StringConcat()
        {
            string str = "";
            Console.WriteLine("Loop Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000; i++)
            {
                str = "DotNet Tutorials" + str;
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
        }
    }

    //Example: String Builder
    class StringBuilderExample
    {
        public StringBuilderExample()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine("Loop Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000; i++)
            {
                stringBuilder.Append("DotNet Tutorials");
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
        }
    }
}
