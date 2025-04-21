using System;

namespace _06_INPUT_OUTPUT_EXAMPLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INPUT / OUTPUT EXAMPLES ===");

            #region Console.WriteLine Example
            // Console.WriteLine() is used to print text/output to the console.
            Console.WriteLine("Welcome to the Input/Output demo!");
            Console.WriteLine("This is another line of output.");
            #endregion

            #region Console.ReadLine Example
            // Console.ReadLine() reads a line of text entered by the user.
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = int.Parse(ageInput); // Convert string to int
            Console.WriteLine("You are " + age + " years old.");
            #endregion

            #region Console.ReadKey Example
            // Console.ReadKey() waits for the user to press a key and returns the key info.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Program will pause here until key is pressed
            #endregion

            
        }
    }
}
