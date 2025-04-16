using System;

namespace _01_REGION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONTROL FLOW EXAMPLES ===");

            #region If - Else If - Else Example
            // The 'if' statement is used to execute code based on a condition.
            // 'else if' and 'else' allow checking additional conditions or fallback.
            int number = 15;

            if (number < 10)
            {
                Console.WriteLine("Number is less than 10");
            }
            else if (number >= 10 && number <= 20)
            {
                Console.WriteLine("Number is between 10 and 20");
            }
            else
            {
                Console.WriteLine("Number is greater than 20");
            }
            #endregion

            #region Switch Case Example
            // 'switch' is used to select one of many blocks of code to be executed.
            // It matches a value with predefined cases.
            string day = "Tuesday";

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Start of the week.");
                    break;
                case "Tuesday":
                    Console.WriteLine("Second day of the week.");
                    break;
                case "Friday":
                    Console.WriteLine("Almost weekend!");
                    break;
                default:
                    Console.WriteLine("Some other day.");
                    break;
            }
            #endregion

            #region Break and Continue Example in Loop
            // 'break' exits the loop entirely.
            // 'continue' skips the current iteration and moves to the next one.
            Console.WriteLine("Loop Example:");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Skipping 3 using continue");
                    continue; // Skip the rest of the loop when i is 3
                }
                if (i == 7)
                {
                    Console.WriteLine("Breaking loop at 7");
                    break; // Exit the loop when i is 7
                }
                Console.WriteLine("i = " + i);
            }
            #endregion
        }
    }
}
