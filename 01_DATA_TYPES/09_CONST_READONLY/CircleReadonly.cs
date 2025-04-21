using System;

namespace _09_CONST_READONLY
{

    /*
         * What is readonly in C#?
         * ----------------------
         * - Definition: A field that can be assigned a value only at declaration or in a constructor, remaining fixed thereafter.
         * - Initialization: Can be set at declaration or in a constructor (instance or static), allowing runtime values.
         * - Scope: Can be instance-level (unique per object) or static (shared across all objects).
         * - Modifiability: Modifiable only at declaration or in a constructor; cannot be changed afterward.
         * - Supported Types: Works with any type, including primitive types (int, double) and complex types (objects, arrays).
         * - Use Case: Ideal for values that vary per instance or depend on runtime conditions but must remain fixed after initialization (e.g., IDs, configurations).
         * - Example: In this class, 'public readonly double Radius' is set in the constructor, allowing each CircleReadonly object to have a unique, fixed radius.
         * ----------------------
    */

    class CircleReadonly
    {
        // Instance-level readonly field for radius
        public readonly double Radius;

        // Constructor to initialize readonly field
        public CircleReadonly(double radius)
        {
            Radius = radius; // Set readonly field in constructor
        }

        public double CalculateArea()
        {
            
            return Radius * Radius * Math.PI;
        }

        public void DisplayRadius()
        {
            Console.WriteLine($"CircleReadonly Radius (readonly): {Radius}");
        }
    }
}