using System;
using System.Collections.Generic;
using System.Text;

namespace _10_PROPERTIES
{
    // Class using auto-implemented properties
    class StudentWithAutoProperties
    {
        // Auto-implemented properties: Compiler creates backing fields
        public string Name { get; set; } // No validation, simple get/set
        public int Age { get; set; }     // No validation, simple get/set
        public int StudentID { get; set; } // No validation, simple get/set
        public string Address { get; set; } // No validation, simple get/set

        // Constructor to initialize properties
        public StudentWithAutoProperties(string name, int age, int studentID, string address)
        {
            Name = name;
            Age = age;
            StudentID = studentID;
            Address = address;
        }

        // Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine($"Student (Auto Properties): ID={StudentID}, Name={Name}, Age={Age}, Address={Address}");
        }
    }
}
