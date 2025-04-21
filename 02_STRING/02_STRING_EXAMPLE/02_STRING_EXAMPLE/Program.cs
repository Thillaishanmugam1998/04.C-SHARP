using System;
using System.Diagnostics;

namespace _02_STRING_EXAMPLE
{
    class Program
    {
        /* What is String?
         * In C#, the string is an object of the String class that represents a sequence of characters. 
         * We can perform many operations on strings such as concatenation, comparison, getting substring, search, trim, replacement, etc.
         * */

        /*
         * Before understanding strings are immutable, first, we need to understand two terms i.e. Mutable and Immutable. 
         * Mutable means can be changed whereas Immutable means can not be changed. C# strings are immutable means C# strings cannot be changed.
         * */

        //string str = "DOTNET";
        //str = "TUTORIALS";
        /*
         * So, when the above two statements are executed, internally two memory locations are created. 
         * When the first statement is executed, one object will be created which holds the value DotNet and that object will be referred 
         * to by the str variable. When the second statement will be executed, another object will be created which holds the value 
         * Tutorials and now the str variable will point to this newly created object. And the first object will be there and will be 
         * available for garbage collection. So, the point that you need to remember is that each time, we assign a new value to the string variable, 
         * a new object is created and that new object will be referred to by the string variable and older objects will be there for garbage collection 
         * and this is the reason why said strings are immutable in C#.
         */

        //01. STRING EXAM
        static void Main(string[] args)
        {
            //Example For Everytime Create a New Object
            //It take Long time beacuse it will create everytime new object
            StringNew stringNew = new StringNew();

            //Example For Integer
            //It take small time because it will not create everytime new object
            IntegerNew integerNew = new IntegerNew();
            

            //Example For StringConcat
            //Here also take everytime new object to create 
            StringConcat stringConcat = new StringConcat();

            //Example For StringBuilder
            StringBuilderExample stringBuilderExample = new StringBuilderExample();




            Console.ReadKey();
        }
    }
}
