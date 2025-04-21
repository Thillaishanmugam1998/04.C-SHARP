using System;
using System.Collections.Generic;
using System.Text;

namespace _10_PROPERTIES
{
    // Class to demonstrate accessing private fields using properties
    class StudentWithProperties
    {
        // Public fields: Directly accessible, no validation (not recommended for sensitive data)
        public int StudentID;
        public string StudentAddress;

        // Private fields: Encapsulated, only accessible via properties
        private string _studentName;
        private int _studentAge;

        // Property for StudentName: Provides controlled access to _studentName
        public string Name
        {
            // Get accessor: Returns the private field's value
            // Set accessor: Sets the private field's value with validation

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Student name cannot be null or empty.");
                }
                _studentName = value;
            }
            get
            {
                return _studentName;
            }
        }

        // Property for StudentAge: Provides controlled access to _studentAge
        public int Age
        {
            // Get accessor: Returns the private field's value
            // Set accessor: Sets the private field's value with validation
            
            set
            {
                _studentAge = value;
            }
            get
            {
                return _studentAge;
            }
        }

        // Constructor: Initializes the object with default values
        public StudentWithProperties()
        {
            _studentName = "Unknown";
            _studentAge = 0;
            StudentID = 0;
            StudentAddress = "Unknown";
        }

        // Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine($"Student Info (With Properties): ID={StudentID}, Name={Name}, Age={Age}, Address={StudentAddress}");
        }
       
    }
}
