using System;
using System.Collections.Generic;
using System.Text;

namespace Example_1
{
    class Student
    {
        #region 01.  non-static members
        public string studentName;
        public int studentRollNo;
        public int subject_1Mark;
        public int subject_2Mark;
        public int subject_3Mark;
        #endregion

        #region 02. static members
        static string schoolName;
        static string className;
        #endregion

        #region 03. Static constructor
        static Student()
        {
            Console.WriteLine("Static constructor called...");
            schoolName = "London KrishnaMoorthy School";
            className = "12'B'";
        }
        #endregion

        #region 04. Default/Parameter less constructor
        public Student()
        {
            Console.WriteLine("Default constructor called...");
        }
        #endregion

        #region 05. Parameterized less construcor
        public Student(string studentName, int studentRollNo, int subject_1Mark, int subject_2Mark, int subject_3Mark)
        {
            Console.WriteLine("Parameterized constructor called..");
            this.studentName = studentName;
            this.studentRollNo = studentRollNo;
            this.subject_1Mark = subject_1Mark;
            this.subject_2Mark = subject_2Mark;
            this.subject_3Mark = subject_3Mark;
        }
        #endregion

        #region 06. Copy construcor
        public Student(Student obj)
        {
            Console.WriteLine("Copy constructor called..");
            this.studentName = obj.studentName;
            this.studentRollNo = obj.studentRollNo;
            this.subject_1Mark = obj.subject_1Mark;
            this.subject_2Mark = obj.subject_2Mark;
            this.subject_3Mark = obj.subject_3Mark;
        }
        #endregion

        #region 07. Display Information
        public void display()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"School Name: {schoolName}");
            Console.WriteLine($"Class  Name: {className}");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Mark_1: {subject_1Mark}");
            Console.WriteLine($"Mark_2: {subject_2Mark}");
            Console.WriteLine($"Mark_3: {subject_3Mark}");
            Console.WriteLine("----------------------------------------------");
        }
        #endregion
    }
}
