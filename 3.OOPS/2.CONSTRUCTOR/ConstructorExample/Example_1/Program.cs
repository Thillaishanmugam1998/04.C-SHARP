using System;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student student1 = new Student();
            Student student2 = new Student();

            student1.display();
            student2.display();

            Student student3 = new Student("Tamil", 1, 100, 100, 100);
            student3.display();

            Student student4 = new Student(student3);
            student4.display();

        }
    }
}
