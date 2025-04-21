using System;

namespace _09_CONST_READONLY
{
    /*
        * What is const in C#?
        * --------------------
        * - Definition: A compile-time constant with a fixed value that cannot be changed.
        * - Initialization: Must be set at declaration with a value computable at compile time (e.g., literals like 5.0, "hello", or expressions like 2 + 3).
        * - Scope: Implicitly static, belongs to the class, not an instance (e.g., accessed as CircleConst.Radius).
        * - Modifiability: Never modifiable after declaration.
        * - Supported Types: Limited to primitive types (int, double, string, etc.), enums, or other constants.
        * - Use Case: Ideal for universal constants, like mathematical values (e.g., Math.PI) or fixed configurations.
        * - Example: In CircleConst.cs, 'public const double Radius = 5.0' defines a fixed radius for all instances.
        * --------------------
        */

    class CircleConst
    {
        // Compile-time constant for radius
        public const double Radius = 5.0;

        public double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }

        public void DisplayRadius()
        {
            Console.WriteLine($"CircleConst Radius (const): {Radius}");
        }
    }
}