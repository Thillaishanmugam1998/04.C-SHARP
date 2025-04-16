using System;

namespace _05_LOOP_EXAMPLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== LOOP EXAMPLES ===");

            #region For Loop Example
            // The 'for' loop runs a block of code a known number of times.
            // Syntax: for (initialization; condition; increment)
            Console.WriteLine("\nFor Loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Iteration " + i);
            }
            #endregion

            #region While Loop Example
            // The 'while' loop runs as long as the condition is true.
            // Useful when you don't know how many times the loop will run.
            Console.WriteLine("\nWhile Loop:");
            int count = 1;
            while (count <= 5)
            {
                Console.WriteLine("Count is: " + count);
                count++;
            }
            #endregion

            #region Do-While Loop Example
            // The 'do-while' loop is similar to 'while' but guarantees at least one execution.
            // It checks the condition after running the loop block.
            Console.WriteLine("\nDo-While Loop:");
            int num = 1;
            do
            {
                Console.WriteLine("Number is: " + num);
                num++;
            } while (num <= 5);
            #endregion

            #region Foreach Loop Example
            // The 'foreach' loop is used to iterate through elements in a collection or array.
            Console.WriteLine("\nForeach Loop:");
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit: " + fruit);
            }
            #endregion
        }
    }
}
