using System;

namespace _10_PROPERTIES
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01. STUDENT WITHOUT PROPERTY EXAMPLE:
            // Demonstration of StudentWithoutProperties (no properties for private fields)
            Console.WriteLine("=== Student Without Properties ===");

            // Create an instance and initialize via constructor
            StudentWithoutProperties studentWithoutProps = new StudentWithoutProperties("Thillai", 50);

            // Set public fields directly (no validation)
            studentWithoutProps.StudentID = 20;
            studentWithoutProps.StudentAddress = "Kumbakonam";

            // Display information
            studentWithoutProps.DisplayInfo();

            // Attempting to access private fields directly will cause a compilation error
            // Error: 'StudentWithoutProperties._studentName' is inaccessible due to its protection level
            // studentWithoutProps._studentName = "THILLAI"; // Uncommenting this will cause an error
            // studentWithoutProps._studentAge = 20; // Uncommenting this will cause an error

            // Problem: No way to modify private fields outside the constructor, limiting flexibility
            Console.WriteLine("Note: Cannot modify private fields (_studentName, _studentAge) without properties.\n");
            #endregion

            #region 02. STUDENT WITH PROPERTY WITH EXAMPLE:
            // Demonstration of StudentWithProperties (using properties for private fields)
            Console.WriteLine("=== Student With Properties ===");
            // Create an instance
            StudentWithProperties studentWithProps = new StudentWithProperties();

            // Set public fields directly (no validation)
            studentWithProps.StudentID = 50;
            studentWithProps.StudentAddress = "Thanjavur";

            // Set private fields using properties (includes validation)
            try
            {
                studentWithProps.Name = "Thillai";
                studentWithProps.Age = 40;
                studentWithProps.DisplayInfo();

                // Try setting invalid values to demonstrate property validation
                studentWithProps.Name = ""; // Will throw an exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Show that valid updates work
            try
            {
                studentWithProps.Name = "Alice";
                studentWithProps.Age = 25;
                studentWithProps.DisplayInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            #endregion

            #region 03. STUDENT WITH AUTO-IMPLEMENT PROPERTY:
            // Demonstration of StudentWithAutoProperties (auto-implemented properties)
            Console.WriteLine("\n=== Student with Auto-Implemented Properties ===");
            
            // Create a student with auto-implemented properties
            StudentWithAutoProperties studentAuto = new StudentWithAutoProperties("Thillai", 40, 2001, "Kumbakonam");
            studentAuto.DisplayInfo();

            // No validation, so empty or invalid values are allowed
            studentAuto.Name = ""; // No exception, but allows invalid data
            studentAuto.Age = -5;  // No exception, but allows invalid data
            studentAuto.DisplayInfo();

            // Update valid values
            studentAuto.Name = "Alice";
            studentAuto.Age = 25;
            studentAuto.DisplayInfo();
            #endregion

        }
    }
}
