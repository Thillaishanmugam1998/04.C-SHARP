using System;
using System.Collections.Generic;
using System.Text;

namespace _10_PROPERTIES
{
    // Class to demonstrate accessing private fields without properties
    class StudentWithoutProperties
    {
        // Public fields: Directly accessible from outside the class, no validation
        public int StudentID;
        public string StudentAddress;

        // Private fields: Not accessible outside the class, no properties provided
        private string _studentName;
        private int _studentAge;

        // Constructor to initialize private fields
        // Parameters: name (student's name), age (student's age)
        public StudentWithoutProperties(string name, int age)
        {
            _studentName = name;
            _studentAge = age;
        }

        // Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine($"Student Info (Without Properties): ID={StudentID}, Name={_studentName}, Age={_studentAge}, Address={StudentAddress}");
        }
    }
}