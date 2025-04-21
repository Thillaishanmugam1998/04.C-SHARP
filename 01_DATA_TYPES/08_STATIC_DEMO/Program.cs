using System;

namespace _08_STATIC_DEMO
{
    public static class MyStaticClass
    {
        public static int number = 50;
        //public int _number = 50; // cannot declare instance members in a static class  08_STATIC_DEMO D:\04_Git Repository\01.C-SHARP\01_DATA_TYPES\08_STATIC_DEMO\Program.cs	8	Active

        public static void SayHello()
        {
            int number = 50;  //static field
            Console.WriteLine("Hello from static!");
        }
    }

    public  class MyNonStaticClass
    {
        int number = 100; //Non static filed 
        public static void SayHello()
        {
            Console.WriteLine("Hello from Non static!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyStaticClass.SayHello();
            int number = MyStaticClass.number;
            MyNonStaticClass.SayHello();
        }
    }
}
