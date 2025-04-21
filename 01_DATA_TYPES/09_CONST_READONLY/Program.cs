using System;

namespace _09_CONST_READONLY
{

    /*
    * Key Differences Between const and readonly:
    * -----------------------------------------------------------------------------------
    * Feature            | const                    | readonly
    * -----------------------------------------------------------------------------------
    * Initialization     | At declaration           | At declaration or in constructor
    * Scope              | Implicitly static        | Instance-level or static
    * Modifiability      | Never modifiable         | Modifiable only in constructor
    * Supported Types    | Primitive types, enums,  | Any type (primitive or complex)
    *                    | strings                  |
    * Value Source       | Compile-time only        | Runtime (e.g., constructor params)
    * Flexibility        | Same value for all       | Different values per instance
    * Use Case           | Universal constants      | Instance-specific fixed values
    *                    | (e.g., Math.PI)          | (e.g., ID, config)
    * ------------------------------------------------------------------------------------
    */

    class Program
    {
        static void Main()
        {
            // Using CircleConst (const)
            CircleConst circleConst = new CircleConst();
            circleConst.DisplayRadius();
            Console.WriteLine($"CircleConst Area: {circleConst.CalculateArea()}");

            // Compilation error if uncommented:
            // CircleConst.Radius = 10.0; // const cannot be modified

            Console.WriteLine(); // Separator for clarity

            // Using CircleReadonly (readonly)
            CircleReadonly circleReadonly1 = new CircleReadonly(5.0);
            CircleReadonly circleReadonly2 = new CircleReadonly(3.0);
            circleReadonly1.DisplayRadius();
            Console.WriteLine($"CircleReadonly1 Area: {circleReadonly1.CalculateArea()}");
            circleReadonly2.DisplayRadius();
            Console.WriteLine($"CircleReadonly2 Area: {circleReadonly2.CalculateArea()}");

            // Compilation error if uncommented:
            // circleReadonly1.Radius = 10.0; // readonly cannot be modified outside constructor
        }
    }
}