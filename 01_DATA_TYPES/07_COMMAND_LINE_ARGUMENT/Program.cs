using System;

namespace _07_COMMAND_LINE_ARGUMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*we can pass parameters to the Main() method and this is possible through 
             * Command Line Arguments in C#. The arguments which are passed by the user or programmer to the 
             * Main() method are termed as Command-Line Arguments in C#. 
             */

            //In C#, the syntax $" " is called an interpolated string.

            //open project properteies and get debug option and type the arguments:

            Console.WriteLine($"First Command Line Argument {args[0]}");
            Console.WriteLine($"Second Command Line Argument {args[1]}");
            Console.WriteLine($"Third Command Line Argument {args[2]}");
            Console.ReadLine();
        }
    }
}
