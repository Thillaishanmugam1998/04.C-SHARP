using System;

namespace _05_FUNCTION_EXAMPLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== FUNCTION EXAMPLES ===");

            #region Built-in Function Example
            // Built-in functions are provided by .NET libraries.
            // Example: Console.WriteLine(), Math.Sqrt(), etc.
            Console.WriteLine("This is a built-in function.");
            double squareRoot = Math.Sqrt(25); // Returns square root of 25
            Console.WriteLine("Square root of 25 is: " + squareRoot);
            #endregion

            #region User-defined Function: No return, No parameter
            // Custom function that performs a task without returning a value or taking parameters
            GreetUser();
            #endregion

            #region User-defined Function: No return, With parameter
            // Function that takes input but doesn't return a value
            DisplayMessage("Hello from a function with parameter!");
            #endregion

            #region User-defined Function: With return, No parameter
            // Function that returns a value but takes no input
            int number = GetRandomNumber();
            Console.WriteLine("Random number is: " + number);
            #endregion

            #region User-defined Function: With return, With parameter
            // Function that takes input and returns a result
            int sum = AddNumbers(10, 20);
            Console.WriteLine("Sum of 10 and 20 is: " + sum);
            #endregion
        }

        // ----------- User-defined Functions Below ------------

        // No return, No parameter
        static void GreetUser()
        {
            Console.WriteLine("Hello! This is a user-defined function with no parameters.");

        }

        // No return, With parameter
        static void DisplayMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        // With return, No parameter
        static int GetRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(1, 101); // Returns random number between 1 and 100
        }

        // With return, With parameter
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
